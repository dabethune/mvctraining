using Microsoft.AspNetCore.Mvc;

namespace mvctraining.Components
{
    public class CommentViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
            List<string> comments = new List<string> { "Nice", "Good" };
            return View("~/Views/Components/_Comment.cshtml", comments);//

        }
    }
}
