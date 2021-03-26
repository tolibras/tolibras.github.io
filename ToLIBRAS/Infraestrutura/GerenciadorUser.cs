using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ToLIBRAS.Areas.Seguranca.Models;
using ToLIBRAS.DAL;

namespace ToLIBRAS.Infraestrutura
{
    public class GerenciadorUser : UserManager<User>
    {
        public GerenciadorUser(IUserStore<User> store) : base(store) { }
        public static GerenciadorUser Create(IdentityFactoryOptions<GerenciadorUser> options, IOwinContext context)
        {
            IdentityDbContextAplicacao db = context.Get<IdentityDbContextAplicacao>();
            GerenciadorUser manager = new GerenciadorUser(new UserStore<User>(db));
            return manager;
        }
    }
}