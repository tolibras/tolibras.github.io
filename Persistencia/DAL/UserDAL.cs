using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia.Contexts;
using Modelo.Tabelas;
using System.Data.Entity;

namespace Persistencia.DAL
{
    public class UserDAL
    {
        private Conexao context = new Conexao();
        public IQueryable<User> ObterUsersClassificadosPeloNome()
        {
            return context.Users.OrderBy(u => u.username);
        }
        public User ObterUserPeloId(int id)
        {
            return context.Users.Where(u => u.id == id).First();
        }
        public void GravarUser(User u)
        {
            if (u.id == null) context.Users.Add(u);
            else context.Entry(u).State = EntityState.Modified;
            context.SaveChanges();
        }
        public User DesativarUser(int id)
        {
            User u = ObterUserPeloId(id);
            u.situacao = false;
            context.Entry(u).State = EntityState.Modified;
            context.SaveChanges();
            return u;
        }
    }
}
