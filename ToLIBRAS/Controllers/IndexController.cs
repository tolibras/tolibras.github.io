using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToLIBRAS.Context;
using ToLIBRAS.Models;
using System.Data.Entity;

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
        public ActionResult Registro()
        {
            return View();
        }

        // POST: Registro
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Registro (User u)
        {
            context.Users.Add(u);
            context.SaveChanges();
            return RedirectToAction("Perfil");
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
        // GET: Perfil
        public ActionResult Perfil()
        {
            return View(context.Users.Last());
        }
        // GET: Delete
        public ActionResult Delete(int id)
        {
            User usuario = context.Users.Find(id);
            context.Users.Remove(usuario);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        // POST: Editar
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(User usuario)
        {
            if (ModelState.IsValid)
            {
                context.Entry(usuario).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Perfil");
            }
            return View(usuario);
        }
    }
}