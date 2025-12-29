using Microsoft.AspNetCore.Mvc;
using PortfolyoSitem.Data;

namespace PortfolyoSitem.ViewComponents.MainPageComponentPartial
{
    public class _MainPageComponentPartial : ViewComponent
    {
        private readonly PortfolyoSitemDbContext _context;
        public _MainPageComponentPartial(PortfolyoSitemDbContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
           var values =  _context.ProfileTables.FirstOrDefault();
            return View(values);
        }
    }
}
