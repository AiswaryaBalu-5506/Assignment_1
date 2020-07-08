using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnMVCUsingViewModel.Models;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnMVCUsingViewModel.Controllers
{
    public class ProductController : Controller
    {
        List<Product> Productslist = new List<Product>()
        {
            new Product() { pID = 1, pName = "Dell Inspiron", price = 100000, stock = "ABC" },
            new Product() { pID = 1, pName = "HP", price = 100000, stock = "XYZ" }
        };

        [HttpGet]
        public IActionResult Index()
        {
            return View(Productslist);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product p)
        {
            //adding project data to list, ony if validation succeeds.          

            if (ModelState.IsValid)
            {
                //later integrate with EF 
                Productslist.Add(p);
                return RedirectToAction("Index");
            }
            else
            {
                if (String.IsNullOrEmpty(p.pID.ToString()))
                {
                    ModelState.AddModelError("pID", "ID Required");
                }
                if (String.IsNullOrEmpty(p.pName))
                {
                    ModelState.AddModelError("pName", "Name Required");
                }
                return RedirectToAction("Err");
            }
             
        }

        [HttpGet]
        public IActionResult Err()
        {
            return View();
        }
    }
}


        
       