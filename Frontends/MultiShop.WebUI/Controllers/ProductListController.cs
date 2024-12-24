using Microsoft.AspNetCore.Mvc;
using MultiShop.Catalog.Entities;
using System;

namespace MultiShop.WebUI.Controllers
{
    public class ProductListController : Controller
    {
        public IActionResult Index(string id)
        {
            ViewBag.i = id;
            return View();
        }
        public IActionResult ProductDetail(string id)
        {
            ViewBag.x = id;
            return View();
        }
    }
}


