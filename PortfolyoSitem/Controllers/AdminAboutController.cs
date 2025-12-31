using Microsoft.AspNetCore.Mvc;
using PortfolyoSitem.Data;

namespace PortfolyoSitem.Controllers
{
    public class AdminAboutController : Controller
    {
        private readonly PortfolyoSitemDbContext _context;
        public AdminAboutController(PortfolyoSitemDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var values = _context.AboutTables.ToList();
            return View(values);
        }
    }
}
