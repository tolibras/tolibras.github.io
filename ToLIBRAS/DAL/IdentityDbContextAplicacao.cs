﻿using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ToLIBRAS.Areas.Seguranca.Models;
//using ToLIBRAS.Migrations;

namespace ToLIBRAS.DAL
{
    public class IdentityDbContextAplicacao : IdentityDbContext<User>
    {
        public IdentityDbContextAplicacao() : base("IdentityDb") { }
        static IdentityDbContextAplicacao()
        {
            Database.SetInitializer<IdentityDbContextAplicacao>(new DropCreateDatabaseIfModelChanges<IdentityDbContextAplicacao>());
        }
        public static IdentityDbContextAplicacao Create()
        {
            return new IdentityDbContextAplicacao();
        }
    }
}