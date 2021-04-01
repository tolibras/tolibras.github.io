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
    public class GerenciadorUsuario : UserManager<User>
    {
        public GerenciadorUsuario(IUserStore<User> store) : base(store)
        { }
        public static GerenciadorUsuario Create(
        IdentityFactoryOptions<GerenciadorUsuario> options, IOwinContext context)
        {
            IdentityDbContextAplicacao db = context.Get<IdentityDbContextAplicacao>();
            GerenciadorUsuario manager = new GerenciadorUsuario(new UserStore<User>(db));
            return manager;
        }
    }
}