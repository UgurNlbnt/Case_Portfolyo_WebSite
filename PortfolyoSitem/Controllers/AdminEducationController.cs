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

        [HttpGet]
        public IActionResult CreateEducation()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateEducation(EducationTable education)
        {
            _context.EducationTables.Add(education);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult UpdateEducation(int id)
        {
            var values = _context.EducationTables.Find(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateEducation(EducationTable education)
        {
            var values = _context.EducationTables.Update(education);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteEducation(int id)
        {
            var values = _context.EducationTables.Find(id);
            _context.EducationTables.Remove(values);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
