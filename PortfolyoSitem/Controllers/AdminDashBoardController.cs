using Microsoft.AspNetCore.Mvc;

namespace PortfolyoSitem.Controllers
{
    public class AdminDashBoardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
