using Microsoft.AspNetCore.Mvc;
using webbansach.Data;

namespace webbansach.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _ad;

        public AdminController(ApplicationDbContext ad)
        {
            _ad = ad;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
