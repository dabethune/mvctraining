using Microsoft.AspNetCore.Mvc;

namespace mvctraining.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
