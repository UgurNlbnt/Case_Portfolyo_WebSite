using Microsoft.AspNetCore.Mvc;
using PortfolyoSitem.Data;

namespace PortfolyoSitem.Controllers
{
    public class AdminExperienceController : Controller
    {
        private readonly PortfolyoSitemDbContext _context;
        public AdminExperienceController(PortfolyoSitemDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var experiences = _context.ExperiencesTables.ToList();
            return View(experiences);
        }
    }
}
