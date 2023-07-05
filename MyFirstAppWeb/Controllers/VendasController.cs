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

        public async Task<IActionResult> Index()
        {
            return _context.Venda != null ?
                             View(await _context.Venda.ToListAsync()) :
                             Problem("Entity set 'MyFirstAppWebContext.Venda'  is null.");
        }

        public IActionResult CriarVenda()
        {
            List<Vendedor> listaVendedores = _context.Vendedor.ToList();
            List<Item> listaItens = _context.Item.ToList();
            ViewBag.Itens = new SelectList(listaItens, "Id_item", "Descricao");
            ViewBag.Vendedores = new SelectList(listaVendedores, "Id_Vendedor", "Nome");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddItem(ItemVenda itemVenda, double quantidade)
        {
            
            
        }

        /*[HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Codigo,Nome,SalarioBase")] Vendedor vendedor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vendedor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vendedor);
        }*/
    }
}
