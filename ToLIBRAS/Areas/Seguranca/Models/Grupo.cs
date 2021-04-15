using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToLIBRAS.Areas.Seguranca.Models
{
    public class Grupo
    {
        public Grupo()
        {
            membros = new List<string>();
            data_criacao = DateTime.Now;
        }
        public int id { get; set; }
        public string nome { get; set; }
        public DateTime data_criacao { get; set; }
        public string desc { get; set; }
        public string adm { get; set; }
        public List<string> membros { get; set; }

        public bool AddMembro(string idM)
        {
            if (idM != null && idM != "" && idM != " ")
            {
                membros.Add(idM);
                return true;
            }
            else throw new Exception("String de id nula");
        }
        public bool AddAdm(string idM)
        {
            if (idM != null && idM != "" && idM != " ")
            {
                adm = idM;
                return true;
            }
            else throw new Exception("String de id nula");
        }
        public override string ToString()
        {
            return nome;
        }
    }
}