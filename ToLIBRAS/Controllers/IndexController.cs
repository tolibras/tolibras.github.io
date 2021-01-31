using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToLIBRAS.Context;

namespace ToLIBRAS.Controllers
{
    public class IndexController : Controller
    {
        public Conexao context = new Conexao();
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

        public ActionResult Alo()
        {
            return View(context.Users.OrderBy(c => c.username));
        }

    }
}