using System.Web.Mvc;
using System.Web.Routing;

namespace FeatureFolderStructure
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            ViewEngines.Engines.Clear();
            ViewEngines.Engines.Add(new FeatureFolderRazorViewEngine());
        }
    }
}
