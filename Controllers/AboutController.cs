using Microsoft.AspNetCore.Mvc;

namespace MarvelMVC.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult index()
        {
            return View();
        }
    }
}