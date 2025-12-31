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
    }
}
