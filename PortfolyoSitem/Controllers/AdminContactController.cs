using Microsoft.AspNetCore.Mvc;
using PortfolyoSitem.Data;

namespace PortfolyoSitem.Controllers
{
    public class AdminContactController : Controller
    {
        private readonly PortfolyoSitemDbContext _context;
        public AdminContactController(PortfolyoSitemDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var values = _context.ContactTables.FirstOrDefault();
            return View(values);
        }
    }
}
