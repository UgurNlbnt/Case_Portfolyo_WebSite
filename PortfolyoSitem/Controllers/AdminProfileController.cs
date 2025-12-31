using Microsoft.AspNetCore.Mvc;
using PortfolyoSitem.Data;

namespace PortfolyoSitem.Controllers
{
    public class AdminProfileController : Controller
    {
        private readonly PortfolyoSitemDbContext _context;
        public AdminProfileController(PortfolyoSitemDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var values = _context.ProfileTables.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateProfile()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateProfile(ProfileTable profileTable)
        {
            _context.ProfileTables.Add(profileTable);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult UpdateProfile(int id)
        {
            var values = _context.ProfileTables.Find(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateProfile(ProfileTable profileTable)
        {
            var values = _context.ProfileTables.Update(profileTable);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteProfile(int id)
        {
            var values = _context.ProfileTables.Find(id);
            _context.ProfileTables.Remove(values);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
