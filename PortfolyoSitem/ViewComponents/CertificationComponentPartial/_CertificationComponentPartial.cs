using Microsoft.AspNetCore.Mvc;
using PortfolyoSitem.Data;

namespace PortfolyoSitem.ViewComponents.CertificationComponentPartial
{
    public class _CertificationComponentPartial : ViewComponent
    {
        private readonly PortfolyoSitemDbContext _context;

        public _CertificationComponentPartial(PortfolyoSitemDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.CertificateTables.ToList();
            return View(values);
        }
    }
}
