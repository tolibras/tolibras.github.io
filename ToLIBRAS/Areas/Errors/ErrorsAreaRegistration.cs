using System.Web.Mvc;

namespace ToLIBRAS.Areas.Errors
{
    public class ErrorsAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Errors";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Errors_default",
                "Errors/{controller}/{action}/{exception}",
                new { action = "Index", exception = UrlParameter.Optional }
            );
        }
    }
}