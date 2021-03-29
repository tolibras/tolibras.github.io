using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToLIBRAS.Areas.Seguranca.Models;
using ToLIBRAS.Infraestrutura;
using System.Web.Security;
using System.Threading.Tasks;
using System.Security.Principal;

namespace ToLIBRAS.Areas.Seguranca.Controllers
{
    public class AdminController : Controller
    {
        private void AddErrorsFromResult(IdentityResult result)
        {
            foreach (string error in result.Errors)
            {
                ModelState.AddModelError("", error);
            }
        }
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
        public ActionResult Atividades()
        {
            return View();
        }
        public ActionResult Revisão()
        {
            return View();
        }
        // GET: Perfil
        public ActionResult Perfil(string name)
        {
            var u = GerenciadorUser.FindByName(name);
            UsuarioViewModel user = new UsuarioViewModel
            {
                Id = u.Id,
                Nome = u.UserName,
                Email = u.Email
            };
            return View(user);
        }
        public ActionResult criarGrupo()
        {
            return View();
        }
        public ActionResult listarGrupos()
        {
            return View();
        }
    }
}
