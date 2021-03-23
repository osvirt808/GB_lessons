using Microsoft.AspNetCore.Mvc;


namespace GB_lessons.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index() => View();
    }
}
