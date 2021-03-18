using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Servico.Tabelas;
using Modelo.Tabelas;
using System.Net;

namespace ToLIBRAS.Controllers
{
    public class IndexController : Controller
    {
        private UserServico userServico = new UserServico();
        private ActionResult ObterVisaoUserPeloId(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            User u = userServico.ObterUserPeloId((int)id);
            if (u == null) return HttpNotFound();
            return View(u);
        }
        private ActionResult GravarUser(User u)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    userServico.GravarUser(u);
                    return RedirectToAction("Perfil");
                }
                return View(u);
            }
            catch
            {
                return View(u);
            }
        }

        // GET: Index
        public ActionResult Index()
        {
            return View();
        }
        // GET: Registro
        public ActionResult Registro()
        {
            return View();
        }

        // POST: Registro
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Registro (User u)
        {
            return GravarUser(u);
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

        // GET: Perfil
        public ActionResult Perfil(int? id)
        {
            return ObterVisaoUserPeloId(id);
        }
        // POST: Delete
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                User u = userServico.DesativarUser(id);
                TempData["Message"] = "Usuario " + u.username.ToUpper() + " foi desativado";
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        // POST: Editar
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(User usuario)
        {
            return GravarUser(usuario);
        }
    }
}