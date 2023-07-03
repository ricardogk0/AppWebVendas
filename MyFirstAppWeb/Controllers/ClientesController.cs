using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using MyFirstAppWeb.Models;

namespace MyFirstAppWeb.Controllers
{
    public class ClientesController : Controller
    {
        public IActionResult Index()
        {
            List<Cliente> list = new List<Cliente>();
            list.Add(new Cliente { Nome = "Cecília", Email = "ceci@hot", Cpf_Cnpj = "124394", Telefone = "98409", TipoCliente = 1 });
            return View(list);
        }
    }
}
