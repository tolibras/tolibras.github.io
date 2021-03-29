using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;
using ToLIBRAS.Areas.Seguranca.Models;
using ToLIBRAS.Infraestrutura;

namespace ToLIBRAS.Areas.Seguranca.Controllers
{
    public class AccountController : Controller
    {
        private void AddErrorsFromResult(IdentityResult result)
        {
            foreach (string error in result.Errors)
            {
                ModelState.AddModelError("", error);
            }
        }
        // Propriedades
        private IAuthenticationManager AuthManager
        {
            get
            {
                return HttpContext.GetOwinContext().Authentication;
            }
        }
        private GerenciadorUser UserManager
        {
            get
            {
                return HttpContext.GetOwinContext().GetUserManager<GerenciadorUser>();
            }
        }
        // Metodos
        public ActionResult Login(string returnUrl)
        {
            ViewBag.returnUrl = returnUrl;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel details, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                User user;
                try
                {
                    user = UserManager.Find(details.Nome, details.Senha);
                }
                catch
                {
                    user = null;
                }
                
                if (user == null)
                {
                    ModelState.AddModelError("", "Nome ou senha inválido(s).");
                }
                else
                {
                    ClaimsIdentity ident = UserManager.CreateIdentity(user,
                    DefaultAuthenticationTypes.ApplicationCookie);
                    AuthManager.SignOut();
                    AuthManager.SignIn(new AuthenticationProperties { IsPersistent = false }, ident);
                    if (returnUrl == null) returnUrl = "/Seguranca/Admin/Atividades";
                    return Redirect(returnUrl);
                }
            }
            return View(details);
        }
        public ActionResult Logout()
        {
            AuthManager.SignOut();
            return RedirectToAction("Index", "Admin", new { area = "Seguranca" });
        }

        // GET: Delete
        public ActionResult Delete(string id)
        {
            User u = UserManager.FindById(id);
            if (u != null)
            {
                IdentityResult result = UserManager.Delete(u);
                if (result.Succeeded)
                {
                    AuthManager.SignOut();
                    return RedirectToAction("Index", "Admin");
                }
                else return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            else return HttpNotFound();
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
                IdentityResult result = UserManager.Create(user, model.Senha);
                if (result.Succeeded)
                {
                    User u = UserManager.Find(user.UserName, model.Senha);
                    ClaimsIdentity ident = UserManager.CreateIdentity(u, DefaultAuthenticationTypes.ApplicationCookie);
                    AuthManager.SignIn(new AuthenticationProperties { IsPersistent = false }, ident);
                    return RedirectToAction("Atividades", "Admin");
                }
                else AddErrorsFromResult(result);
            }
            return View(model);
        }

        //POST: Editar
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(UsuarioViewModel usuario)
        {
            if (ModelState.IsValid)
            {
                User user = UserManager.FindById(usuario.Id);
                user.UserName = usuario.Nome;
                user.Email = usuario.Email;
                user.PasswordHash = UserManager.PasswordHasher.HashPassword(usuario.Senha);

                IdentityResult result = UserManager.Update(user);
                if (result.Succeeded)
                {
                    ClaimsIdentity ident = UserManager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);
                    AuthManager.SignOut();
                    AuthManager.SignIn(new AuthenticationProperties { IsPersistent = false }, ident);
                    return RedirectToAction("Perfil", "Admin", new { name = user.UserName });
                }
                else AddErrorsFromResult(result);
            }
            return View(usuario);
        }
    }
}