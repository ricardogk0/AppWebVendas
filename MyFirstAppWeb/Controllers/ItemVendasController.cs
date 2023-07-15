﻿using System;
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
    public class ItemVendasController : Controller
    {
        private readonly MyFirstAppWebContext _context;
        // GET: ItemVendasController

        public ItemVendasController(MyFirstAppWebContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {  
            var itens = _context.Item.ToList();
            return View(itens);
        }

        // GET: ItemVendasController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ItemVendasController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ItemVendasController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ItemVendasController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ItemVendasController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ItemVendasController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ItemVendasController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
