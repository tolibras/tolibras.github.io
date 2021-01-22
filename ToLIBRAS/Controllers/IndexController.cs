using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ToLIBRAS.Controllers
{
    public class IndexController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {
            return View();
        }

        // GET: Registro
        public ActionResult Registro ()
        {
            return View();
        }

        // GET: Atividades
        public ActionResult Atividades ()
        {
            return View();
        }

        // GET: Revisão
        public ActionResult Revisão ()
        {
            return View();
        }
    }
}