using Microsoft.AspNetCore.Mvc;
using PortfolyoSitem.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

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
            var values = _context.ProjectsTables.Include(x => x.Category).ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateProject()
        {
            List<SelectListItem> categoryValues = (from x in _context.CategoryTables.ToList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryId.ToString()
                                                   }).ToList();
            ViewBag.v = categoryValues;
            return View();
        }

        [HttpPost]
        public IActionResult CreateProject(ProjectsTable project)
        {
            _context.ProjectsTables.Add(project);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult UpdateProject(int id)
        {
            List<SelectListItem> categoryValues = (from x in _context.CategoryTables.ToList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryId.ToString()
                                                   }).ToList();
            ViewBag.v = categoryValues;
            var values = _context.ProjectsTables.Find(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateProject(ProjectsTable project)
        {
            var values = _context.ProjectsTables.Update(project);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteProject(int id)
        {
            var values = _context.ProjectsTables.Find(id);
            _context.ProjectsTables.Remove(values);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
