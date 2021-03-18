using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Modelo.Tabelas
{
    public class User
    {
        public int? id { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string pwser { get; set; }
        public bool situacao { get; set; } 
    }
}