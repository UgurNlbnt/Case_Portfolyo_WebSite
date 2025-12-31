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

        [HttpGet]
        public IActionResult CreateAbout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateAbout(AboutTable education)
        {
            _context.AboutTables.Add(education);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult UpdateAbout(int id)
        {
            var values = _context.AboutTables.Find(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateAbout(AboutTable education)
        {
            var values = _context.AboutTables.Update(education);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteAbout(int id)
        {
            var values = _context.AboutTables.Find(id);
            _context.AboutTables.Remove(values);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
