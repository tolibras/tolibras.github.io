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
using ToLIBRAS.DAL;

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
        private GrupoContext contextG;
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
        public ActionResult Grupos(string name)
        {
            var u = GerenciadorUser.FindByName(name);
            return View(u.grupos);
        }
        public ActionResult criarGrupo()
        {
            return View();
        }
        [HttpPost]
        public ActionResult criarGrupo(Grupo g, string name)
        {
            if (ModelState.IsValid)
            {
                var u = GerenciadorUser.FindByName(name);
                User user = GerenciadorUser.FindById(u.Id);
                g.adm = user;
                g.data_criacao = DateTime.Now;
                user.grupos.Add(g);
                IdentityResult result = GerenciadorUser.Update(user);
                if (result.Succeeded)
                {
                    contextG.Grupos_Users.Add(g);
                    contextG.SaveChanges();
                    return RedirectToAction("Grupos", "Admin", new { area = "Seguranca", name = name });
                }
                else
                {
                    return View(g);
                }
            }
            else return View(g);
                
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
        public ActionResult listarGrupos()
        {
            return View();
        }
    }
}
