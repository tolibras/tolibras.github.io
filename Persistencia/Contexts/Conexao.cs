using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Modelo.Tabelas;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Persistencia.Contexts
{
    public class Conexao : DbContext
    {
        public Conexao() : base("Asp_Net_MVC_CS")
        {
            Database.SetInitializer<Conexao>(new DropCreateDatabaseIfModelChanges<Conexao>());
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Adm> Adms { get; set; }
        public DbSet<Grupo_Users> Grupos_Users { get; set; }
        public DbSet<Atividade> Atividades { get; set; }
        public DbSet<Questao> Questaos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}