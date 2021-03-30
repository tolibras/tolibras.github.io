using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToLIBRAS.Areas.Seguranca.Models
{
    public class Grupo
    {
        public int id { get; set; }
        public string nome { get; set; }
        public DateTime data_criacao { get; set; }
        public string desc { get; set; }
        public User adm { get; set; }
        public List<User> membros { get; set; }
        public override string ToString()
        {
            return nome;
        }
    }
}