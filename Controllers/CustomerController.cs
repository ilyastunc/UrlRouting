using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UrlRouting.Models;

namespace UrlRouting.Controllers
{
    [Route("api/[action]/{id?}")] //api/index ile customer'ın altındaki index metoduna gidebiliriz.
    public class CustomerController : Controller
    {
        //[Route("customers")]  //attribute routing   url'e customers yazdığımızda customer'ın altındaki index methodu çağrılır.
        //[Route("[controller]/all")] //customer/all ile customer'ın altındaki index çağrılır.
        public IActionResult Index()
        {
            return View("MyView", new Result() {
                Controller = "CustomerController",
                Action = "Index"
            });
        }

        public IActionResult List()
        {
            return View("MyView", new Result() {
                Controller = "CustomerController",
                Action = "List"
            });
        }
    }
}