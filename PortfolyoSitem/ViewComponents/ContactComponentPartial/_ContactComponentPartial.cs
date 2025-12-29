using PortfolyoSitem.Data;

namespace PortfolyoSitem.ViewComponents.ContactComponentPartial
{
    public class _ContactComponentPartial : Microsoft.AspNetCore.Mvc.ViewComponent
    {
        private readonly PortfolyoSitemDbContext _context;

        public _ContactComponentPartial(PortfolyoSitemDbContext context)
        {
            _context = context;
        }
        public Microsoft.AspNetCore.Mvc.IViewComponentResult Invoke()
        {
            var values = _context.ContactTables.FirstOrDefault();
            return View(values);
        }
    }
}
