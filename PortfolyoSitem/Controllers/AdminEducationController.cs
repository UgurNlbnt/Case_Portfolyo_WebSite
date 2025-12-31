using Microsoft.AspNetCore.Mvc;
using PortfolyoSitem.Data;

namespace PortfolyoSitem.Controllers
{
    public class AdminEducationController : Controller
    {
        private readonly PortfolyoSitemDbContext _context;
        public AdminEducationController(PortfolyoSitemDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var values = _context.EducationTables.ToList();
            return View(values);
        }
    }
}
