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
        private GerenciadorUsuario GerenciadorUser
        {
            get
            {
                return HttpContext.GetOwinContext().GetUserManager<GerenciadorUsuario>();
            }
        }
        private GrupoContext contextG = new GrupoContext(); 
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
        /*public ActionResult Grupos(string name)
        {
            var u = GerenciadorUser.FindByName(name);
            return View(u.grupos);
        }*/
        public ActionResult Grupos()
        {
            return View();
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
                try
                {
                    User u = GerenciadorUser.FindByName(name) as User;
                    g.AddMembro(u.Id);
                    g.AddAdm(u.Id);
                    contextG.Grupos_Users.Add(g);
                    int i = 1 + 1;
                    contextG.SaveChanges();
                    u.AddGrupo(g.id);

                   
                }
                catch(Exception e)
                {
                    TempData["exception"] = e;
                    return RedirectToAction("Erro", "Erro",  new { area = "Errors", exception = e.Message });
                }

                


                /*User user = GerenciadorUser.FindById(u.Id);
                g.adm = user;
                g.data_criacao = DateTime.Now;
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
                }*/
                return RedirectToAction("Grupos", "Admin");
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
        public ActionResult GrupoDetails()
        {
            return View();
        }
        public ActionResult MembrosDetails()
        {
            return View();
        }
        public ActionResult AdmDetails()
        {
            return View();
        }

    }
}
