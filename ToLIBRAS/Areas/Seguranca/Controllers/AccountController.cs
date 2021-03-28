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
                User user = UserManager.Find(details.Nome, details.Senha);
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
                    if (returnUrl == null) returnUrl = "/Seguranca/Admin/Index";
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
                    return RedirectToAction("Index");
                }
                else return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            else return HttpNotFound();
        }
    }
}