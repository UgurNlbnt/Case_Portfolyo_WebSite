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
            var values = _context.SkillsTables.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateSkill()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateSkill(SkillsTable project)
        {
            _context.SkillsTables.Add(project);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult UpdateSkill(int id)
        {
            var values = _context.SkillsTables.Find(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateSkill(SkillsTable project)
        {
            var values = _context.SkillsTables.Update(project);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteSkill(int id)
        {
            var values = _context.SkillsTables.Find(id);
            _context.SkillsTables.Remove(values);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
