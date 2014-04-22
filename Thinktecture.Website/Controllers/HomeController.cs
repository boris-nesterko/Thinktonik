using System.Web.Mvc;

namespace Twinfield.Thinktecture.Website.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Thinktecture - Home Page";
	        ViewBag.Header = "Header";

            return View();
        }
    }
}
