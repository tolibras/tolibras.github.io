using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToLIBRAS.Infraestrutura;

namespace ToLIBRAS.Areas.Seguranca.Controllers
{
    public class AdminController : Controller
    {
        private GerenciadorUser GerenciadorUser
        {
            get
            {
                return HttpContext.GetOwinContext().GetUserManager<GerenciadorUser>();
            }
        }
        // GET: Seguranca/Admin
        public ActionResult Index()
        {
            return View();
        }
    }
}