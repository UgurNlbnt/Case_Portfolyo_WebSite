using Microsoft.AspNetCore.Mvc;
using PortfolyoSitem.Data;

namespace PortfolyoSitem.Controllers
{
    public class AdminDashBoardController : Controller
    {
        private readonly PortfolyoSitemDbContext _context;
        public AdminDashBoardController(PortfolyoSitemDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.totalProjects = _context.ProjectsTables.Count();

            ViewBag.totalCategories = _context.CategoryTables.Count();

            ViewBag.firstProject = _context.ProjectsTables
                .OrderBy(p => p.ProjectId)
                .Select(p => p.ProjectName)
                .FirstOrDefault();

            ViewBag.lastProject = _context.ProjectsTables
                .OrderByDescending(p => p.ProjectId)
                .Select(p => p.ProjectName)
                .FirstOrDefault();

            var mostUsedCategoryId = _context.ProjectsTables
                .GroupBy(p => p.CategoryId)
                .OrderByDescending(g => g.Count())
                .Select(g => g.Key)
                .FirstOrDefault();

            ViewBag.MostUsedCategoryName = _context.CategoryTables
                .Where(c => c.CategoryId == mostUsedCategoryId)
                .Select(c => c.CategoryName)
                .FirstOrDefault();

            ViewBag.firstExperience = _context.ExperiencesTables
                .OrderBy(e => e.ExperienceId)
                .Select(e => e.Title)
                .FirstOrDefault();

            ViewBag.totalCertificates = _context.CertificateTables.Count();

            ViewBag.firstUniversity = _context.EducationTables
                .OrderBy(e => e.EducationId)
                .Select(e => e.SchoolName)
                .FirstOrDefault();

            ViewBag.bestSkill = _context.SkillsTables
                 .OrderByDescending(s => s.SkillsPercent)
                 .Select(s => s.SkillName).FirstOrDefault();



            return View();
        }

    }
}
