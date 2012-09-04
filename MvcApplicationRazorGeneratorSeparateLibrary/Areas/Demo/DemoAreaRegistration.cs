using System.Web.Mvc;

namespace MvcApplicationRazorGeneratorSeparateLibrary.Areas.Demo
{
    public class DemoAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Demo";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Demo_default",
                "Demo/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
