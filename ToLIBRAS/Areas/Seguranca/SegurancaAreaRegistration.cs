using System.Web.Mvc;

namespace ToLIBRAS.Areas.Seguranca
{
    public class SegurancaAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Seguranca";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Seguranca_default",
                "Seguranca/{controller}/{action}/{name}",
                new { action = "Admin", name = UrlParameter.Optional }
            );
        }
    }
}