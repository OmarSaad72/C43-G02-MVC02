using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetMovie(int id) { return View(); }
    }
}
