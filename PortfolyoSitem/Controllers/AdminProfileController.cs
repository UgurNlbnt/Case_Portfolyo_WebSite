using Microsoft.AspNetCore.Mvc;
using PortfolyoSitem.Data;

namespace PortfolyoSitem.Controllers
{
    public class AdminProfileController : Controller
    {
        private readonly PortfolyoSitemDbContext _context;
        public AdminProfileController(PortfolyoSitemDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var values = _context.ProfileTables.ToList();
            return View(values);
        }
    }
}
