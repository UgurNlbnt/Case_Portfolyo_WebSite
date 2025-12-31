using Microsoft.AspNetCore.Mvc;
using PortfolyoSitem.Data;
using System.Data.Entity;

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
            var values = _context.ContactTables.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateContact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateContact(ContactTable education)
        {
            _context.ContactTables.Add(education);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult UpdateContact(int id)
        {
            var values = _context.ContactTables.Find(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateContact(ContactTable education)
        {
            var values = _context.ContactTables.Update(education);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteContact(int id)
        {
            var values = _context.ContactTables.Find(id);
            _context.ContactTables.Remove(values);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
