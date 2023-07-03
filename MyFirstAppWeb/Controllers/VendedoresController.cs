using Microsoft.AspNetCore.Mvc;
using MyFirstAppWeb.Models;
using System.Collections.Generic;

namespace MyFirstAppWeb.Controllers
{
    public class VendedoresController : Controller
    {
        public IActionResult Index()
        {
            List<Vendedor> list = new List<Vendedor>();

            list.Add(new Vendedor { Codigo = 01, Nome = "Ricardo", SalarioBase = 2 });

            return View(list);
        }
    }
}
