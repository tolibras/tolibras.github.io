using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using ToLIBRAS.Areas.Seguranca.Models;

namespace ToLIBRAS.DAL
{
    public class GrupoContext : DbContext
    {
        public GrupoContext() : base("IdentityDb")
        {
            Database.SetInitializer<GrupoContext>(new DropCreateDatabaseIfModelChanges<GrupoContext>());
        }
        public DbSet<Grupo> Grupos_Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}