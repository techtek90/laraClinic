using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class TermsAndConditions : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
