using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToLIBRAS.Areas.Seguranca.Models;

namespace ToLIBRAS.Infraestrutura
{
    public static class IdentityHelpers
    {
        public static MvcHtmlString GetUserName(this HtmlHelper html, string id)
        {
            GerenciadorUser mgr = HttpContext.Current.GetOwinContext().GetUserManager<GerenciadorUser>();
            return new MvcHtmlString(mgr.FindByIdAsync(id).Result.UserName);
        }
        public static MvcHtmlString GetAuthenticatedUser(this HtmlHelper html)
        {
            return new MvcHtmlString(HttpContext.Current.User.Identity.Name);
        }
    }
}