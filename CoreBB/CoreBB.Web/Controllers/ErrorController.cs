using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CoreBB.Web.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult Index()
        {
            var exception = HttpContext.Features.Get<IExceptionHandlerFeature>();
            ViewData["StatusCode"] = HttpContext.Response.StatusCode;
            ViewData["Message"] = exception.Error.Message;
            ViewData["StackTrace"] = exception.Error.StackTrace;

            return View();
        }

        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
