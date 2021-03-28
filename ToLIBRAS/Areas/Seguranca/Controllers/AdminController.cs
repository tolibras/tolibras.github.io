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
        public ActionResult Registro()
        { 
            return View(); 
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Registro(UsuarioViewModel model)
        {
            if (ModelState.IsValid)
            {
                User user = new User
                {
                    UserName = model.Nome,
                    Email = model.Email
                };
                IdentityResult result = GerenciadorUser.Create(user, model.Senha);
                if (result.Succeeded) return RedirectToAction("Atividades");
                else AddErrorsFromResult(result);
            }
            return View(model);
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
            User user = new User
            {
                Id = u.Id,
                UserName = u.UserName,
                Email = u.Email
            };
            return View(user);
        }
        
        //POST: Editar
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(User usuario)
        {
            if (ModelState.IsValid)
            {
                IdentityResult result = GerenciadorUser.Update(usuario);
                if (result.Succeeded) return RedirectToAction("Perfil", usuario.UserName);
                else AddErrorsFromResult(result);
            }
            return View(usuario);
        }
    }
}
