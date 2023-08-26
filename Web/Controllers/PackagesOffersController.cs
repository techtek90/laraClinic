using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class PackagesOffersController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
