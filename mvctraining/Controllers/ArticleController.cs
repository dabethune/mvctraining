using Microsoft.AspNetCore.Mvc;

namespace mvctraining.Controllers
{
    public class ArticleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
