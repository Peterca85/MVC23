using System;
using Microsoft.AspNetCore.Mvc;

namespace WebMVC23.Controllers
{
    public class ProductsController : Controller

    {
        public IActionResult Index()
        //ok

        {
            return View();
        }


    }
}

