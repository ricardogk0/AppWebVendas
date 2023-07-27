using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyFirstAppWeb.Data;
using MyFirstAppWeb.Models;

namespace MyFirstAppWeb.Controllers
{
    public class VendasController : Controller
    {
        private readonly MyFirstAppWebContext _context;


        public VendasController(MyFirstAppWebContext context)
        {
            _context = context;
        }

        // GET: Vendas
        public async Task<IActionResult> Index()
        {
              return _context.Venda != null ? 
                          View(await _context.Venda.ToListAsync()) :
                          Problem("Entity set 'MyFirstAppWebContext.Venda'  is null.");
        }

        // GET: Vendas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Venda == null)
            {
                return NotFound();
            }

            var venda = await _context.Venda
                .FirstOrDefaultAsync(m => m.IdVenda == id);
            if (venda == null)
            {
                return NotFound();
            }

            return View(venda);
        }

        // GET: Vendas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Vendas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdVenda,Numero_Cupom,Vendedor,ValorTotal,Data")] Venda venda)
        {          
            if (ModelState.IsValid)
            {
                _context.Add(venda);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(venda);
        }

        // GET: Vendas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Venda == null)
            {
                return NotFound();
            }

            var venda = await _context.Venda.FindAsync(id);
            if (venda == null)
            {
                return NotFound();
            }
            return View(venda);
        }

        // POST: Vendas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdVenda,Numero_Cupom,ValorTotal,Data")] Venda venda)
        {
            if (id != venda.IdVenda)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(venda);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VendaExists(venda.IdVenda))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(venda);
        }

        // GET: Vendas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Venda == null)
            {
                return NotFound();
            }

            var venda = await _context.Venda
                .FirstOrDefaultAsync(m => m.IdVenda == id);
            if (venda == null)
            {
                return NotFound();
            }

            return View(venda);
        }

        // POST: Vendas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Venda == null)
            {
                return Problem("Entity set 'MyFirstAppWebContext.Venda'  is null.");
            }
            var venda = await _context.Venda.FindAsync(id);
            if (venda != null)
            {
                _context.Venda.Remove(venda);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult AddItemVenda()
        {
            return RedirectToAction("Index", "ItemVendas");
        }

        [HttpGet]
        public IActionResult BuscarProduto(string produto)
        {
            var PorCodigo = _context.Item.FirstOrDefault(i => i.Codigo == produto);
            var PorNome = _context.Item.FirstOrDefault(i => i.Descricao == produto);

            if (PorCodigo != null)
            {
                var response = new
                {
                    item = PorCodigo.Descricao,
                    preco = PorCodigo.Preco
                };

                return Json(response);
            }
            else if (PorNome != null)
            {
                var response = new
                {
                    item = PorCodigo.Descricao,
                    preco = PorCodigo.Preco
                };

                return Json(response);
            }

            return NotFound();
        }

        [HttpGet]
        public IActionResult BuscarVendedor(string vendedor)
        {
            var PorCodigo = _context.Vendedor.FirstOrDefault(v => v.Codigo.ToString() == vendedor);
            var PorNome = _context.Vendedor.FirstOrDefault(v => v.Nome == vendedor);

            if (PorCodigo != null)
            {
                var response = new
                {
                    nome = PorCodigo.Nome
                };
                return Json(response);
            }

            if (PorNome != null)
            {
                var response = new
                {
                    nome = PorCodigo.Nome
                };
                return Json(response);
            }

            return NotFound();
        }

        [HttpGet]
        public IActionResult BuscarCliente(string cliente)
        {
            var PorCodigo = _context.Cliente.FirstOrDefault(v => v.Codigo == cliente);
            var PorNome = _context.Cliente.FirstOrDefault(v => v.Nome == cliente);

            if (PorCodigo != null)
            {
                var response = new
                {
                    nome = PorCodigo.Nome
                };
                return Json(response);
            }

            if (PorNome != null)
            {
                var response = new
                {
                    nome = PorCodigo.Nome
                };
                return Json(response);
            }

            return NotFound();
        }

        [HttpGet]
        public IActionResult PesquisarVendedores()
        {
            var vendedores = _context.Vendedor.ToList();
            return Json(vendedores);
        }

        private bool VendaExists(int id)
        {
          return (_context.Venda?.Any(e => e.IdVenda == id)).GetValueOrDefault();
        }
    }
}
