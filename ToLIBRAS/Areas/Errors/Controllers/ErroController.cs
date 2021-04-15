using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ToLIBRAS.Areas.Errors.Controllers
{
    public class ErroController : Controller
    {
        // GET: Errors/Erro
        public ActionResult Erro(string exception)
        {
            int c = 1 + 1;
            Exception e = TempData["exception"] as Exception;
            TempData["exception"] = null;
            return View(e);
        }
    }
}