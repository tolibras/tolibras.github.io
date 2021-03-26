using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Modelo.Tabelas;
using Servico.Tabelas;
using ToLIBRAS.Areas.Seguranca.Models;

namespace ToLIBRAS.Controllers
{
    public class AdministracaoController : Controller
    {

        private User ProcureUserPeloUsername(string username)
        {
            User u = new User();
            try
            {
                // TODO: Add delete logic here

                return u;
            }
            catch
            {
                return u;
            }
        }

        // GET: Administracao
        public ActionResult CriarGrupo()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CriarGrupo(Grupo_Users gu)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Administracao/Details/5
        public ActionResult DetailsGrupo(int id)
        {
            return View();
        }

        // GET: Administracao/Edit/5
        public ActionResult EditGrupo(int id)
        {
            return View();
        }

        // POST: Administracao/Edit/5
        [HttpPost]
        public ActionResult EditGrupo(Grupo_Users gu)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // POST: Administracao/Delete/5
        [HttpPost]
        public ActionResult DeleteGrupo(int id)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // POST: Administracao/Delete/5
        [HttpPost]
        public ActionResult DesativarGrupo(int id)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult AddUserPeloUsername()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddUserPeloUsername(string username)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult ListarUsersNoGrupo()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RemoverUserDoGrupo(User u)
        {
            return View();
        }

        public ActionResult DefinirAtividades()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DefinirAtividades(List<Atividade> ativs)
        {
            return View();
        }
    }
}
