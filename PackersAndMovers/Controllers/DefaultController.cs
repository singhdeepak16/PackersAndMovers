using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PackersAndMovers.Controllers
{
    public class DefaultController : Controller
    {
        // GET: DefaultController
        public ActionResult Index()
        {
            return View();
        }


        public IActionResult About()
        {
            return View();
        }
        public IActionResult Services()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        public ActionResult Default()
        {
            return View();
        }

    }
}
