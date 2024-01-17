using Microsoft.AspNetCore.Mvc;
using MVCCoreApp3.Models;


namespace MVCCoreApp3.Controllers
{
    public class SumController : Controller
    {
       
        [HttpGet]
        public IActionResult Add()
        {
            Numbers numbers = new Numbers();
            return View(numbers);
        }
        [HttpPost]
        public IActionResult Add(Numbers numbers)
        {
            ViewBag.res = numbers.Num1 + numbers.Num2;
            return View();

        }
    }
}


﻿