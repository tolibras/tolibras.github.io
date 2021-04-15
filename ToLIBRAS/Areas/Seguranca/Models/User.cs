using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToLIBRAS.Areas.Seguranca.Models
{
    public class User : IdentityUser
    {
        public User() : base()
        {
            grupos = new List<int>();
        }
        public List<int> grupos { get; set; }
        
        public bool AddGrupo(int? id)
        {
            if (id != null)
            {
                grupos.Add((int)id);
                return true;
            }
            else throw new Exception("Inteiro de id está nulo");
        }
    }
}