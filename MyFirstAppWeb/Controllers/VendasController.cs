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
                             Problem("Entity set 'MyFirstAppWebContext.Vendedor'  is null.");
        }

        [HttpPost]
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
        }
    }
}
