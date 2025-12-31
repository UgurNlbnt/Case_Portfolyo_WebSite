using Microsoft.AspNetCore.Mvc;
using PortfolyoSitem.Data;

namespace PortfolyoSitem.Controllers
{
    public class AdminCertificateController : Controller
    {
        private readonly PortfolyoSitemDbContext _context;
        public AdminCertificateController(PortfolyoSitemDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var values = _context.CertificateTables.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateCertificate()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateCertificate(CertificateTable education)
        {
            _context.CertificateTables.Add(education);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult UpdateCertificate(int id)
        {
            var values = _context.CertificateTables.Find(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateCertificate(CertificateTable education)
        {
            var values = _context.CertificateTables.Update(education);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteCertificate(int id)
        {
            var values = _context.CertificateTables.Find(id);
            _context.CertificateTables.Remove(values);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
