using Microsoft.AspNetCore.Mvc;

namespace mvctraining.Controllers
{
    public class EmployeeController : Controller
    {
        [Route("Employee/index/{id}/{deptid}")]
        [Route("employee-details/index/{id}/{deptid}")]
        public IActionResult Index(int id, int deptid)
        {
            return View();
        }
    }
}
