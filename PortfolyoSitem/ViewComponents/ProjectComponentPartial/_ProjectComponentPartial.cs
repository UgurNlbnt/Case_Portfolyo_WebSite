using Microsoft.AspNetCore.Mvc;
using PortfolyoSitem.Data;

namespace PortfolyoSitem.ViewComponents.ProjectComponentPartial
{

    public class _ProjectComponentPartial : ViewComponent
    {

        private readonly PortfolyoSitemDbContext _context;
        
        public _ProjectComponentPartial(PortfolyoSitemDbContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var values = _context.ProjectsTables.ToList();
            return View(values);
        }
    }
}
