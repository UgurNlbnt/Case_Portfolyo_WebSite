using Microsoft.AspNetCore.Mvc;

namespace PortfolyoSitem.Controllers
{
    public class HomeLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
