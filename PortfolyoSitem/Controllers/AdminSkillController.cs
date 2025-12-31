using Microsoft.AspNetCore.Mvc;
using PortfolyoSitem.Data;

namespace PortfolyoSitem.Controllers
{
    public class AdminSkillController : Controller
    {
        private readonly PortfolyoSitemDbContext _context;
        public AdminSkillController(PortfolyoSitemDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var skills = _context.SkillsTables.ToList();
            return View(skills);
        }
    }
}
