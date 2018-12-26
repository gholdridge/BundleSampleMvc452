using System.Diagnostics;
using System.Web;
using System.Web.Routing;

namespace BundleSample
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            Debug.WriteLine("***************************** Application Start ********************************");
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}