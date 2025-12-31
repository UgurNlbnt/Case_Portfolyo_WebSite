using Microsoft.AspNetCore.Mvc;

namespace PortfolyoSitem.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
