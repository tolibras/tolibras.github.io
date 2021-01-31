using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ToLIBRAS.Models;

namespace ToLIBRAS.Context
{
    public class Conexao : DbContext
    {
        public Conexao() : base("Asp_Net_MVC_CS"){ }
        public DbSet<User> Users { get; set; }
    }
}