using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Tabelas;
using Persistencia.DAL;

namespace Servico.Tabelas
{
    public class UserServico
    {
        private UserDAL userDAL = new UserDAL();
        public IQueryable<User> ObterUserClassificadosPeloNome()
        {
            return userDAL.ObterUsersClassificadosPeloNome();
        }
        public User ObterUserPeloId(int id)
        {
            return userDAL.ObterUserPeloId(id);
        }
        public void GravarUser(User u)
        {
            userDAL.GravarUser(u);
        }
        public User DesativarUser(int id)
        {
            return userDAL.DesativarUser(id);
        }
    }
}
