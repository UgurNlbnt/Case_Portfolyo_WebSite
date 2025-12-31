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
            var values = _context.ExperiencesTables.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateExperience()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateExperience(ExperiencesTable experiences)
        {
            _context.ExperiencesTables.Add(experiences);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult UpdateExperience(int id)
        {
            var values = _context.ExperiencesTables.Find(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateExperience(ExperiencesTable experiences)
        {
            var values = _context.ExperiencesTables.Update(experiences);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteExperience(int id)
        {
            var values = _context.ExperiencesTables.Find(id);
            _context.ExperiencesTables.Remove(values);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
