using Microsoft.AspNetCore.Mvc;
using PortfolyoSitem.Data;

namespace PortfolyoSitem.Controllers
{
    public class AdminProjectController : Controller
    {
        private readonly PortfolyoSitemDbContext _context;
        public AdminProjectController(PortfolyoSitemDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var projects = _context.ProjectsTables.ToList();
            return View(projects);
        }
    }
}
