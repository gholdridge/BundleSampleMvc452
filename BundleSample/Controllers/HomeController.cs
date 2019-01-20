using System.Web.Mvc;

namespace BundleSample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // Testing OzCode
            for (int i = 0; i < 10; i++)
            {
                System.Console.WriteLine($"Hello {i}");
            }


            return View(); 
        }
    }
}