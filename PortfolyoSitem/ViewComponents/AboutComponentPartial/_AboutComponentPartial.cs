using PortfolyoSitem.Data;

namespace PortfolyoSitem.ViewComponents.AboutComponentPartial
{
    public class _AboutComponentPartial : Microsoft.AspNetCore.Mvc.ViewComponent
    {
        private readonly PortfolyoSitemDbContext _context;


        public _AboutComponentPartial(PortfolyoSitemDbContext context)
        {
            _context = context;
        }

        public Microsoft.AspNetCore.Mvc.IViewComponentResult Invoke()
        {
            var values = _context.AboutTables.FirstOrDefault();
            return View(values);
        }
    }
}
