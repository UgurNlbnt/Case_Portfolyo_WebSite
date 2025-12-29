using Microsoft.AspNetCore.Mvc;
using PortfolyoSitem.Data;

namespace PortfolyoSitem.ViewComponents.EducationComponentPartial
{
    public class _EducationComponentPartial : ViewComponent
    {
        private readonly PortfolyoSitemDbContext _context;
        public _EducationComponentPartial(PortfolyoSitemDbContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var values = _context.EducationTables.ToList();
            return View(values);
        }
    }
}
