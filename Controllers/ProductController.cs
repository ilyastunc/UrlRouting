using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UrlRouting.Models;

namespace UrlRouting.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View("MyView", new Result() {
                Controller = "ProductController",
                Action = "Index"
            });
        }

        public IActionResult List()
        {
            return View("MyView", new Result() {
                Controller = "ProductController",
                Action = "List"
            });
        }

        public IActionResult Newest()
        {
            return View("MyView", new Result() {
                Controller = "ProductController",
                Action = "Newest"
            });
        }

        public IActionResult Details()
        {
            var result = new Result();
            result.Controller = "ProductController";
            result.Action = "Details";
            result.RouteData["id"] = RouteData.Values["id"]; //eşitliğin sağ tarafıdaki id default route'da yazdığımız değer ile aynı olmalı.
            result.RouteData["extraparams"] = RouteData.Values["extraparams"];

            return View("MyView", result);
        }
    }
}