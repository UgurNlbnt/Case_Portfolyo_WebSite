using PortfolyoSitem.Data;

namespace PortfolyoSitem.ViewComponents.ExperienceComponentPartial
{
    public class _ExperienceComponentPartial : Microsoft.AspNetCore.Mvc.ViewComponent
    {
        private readonly PortfolyoSitemDbContext _context;
        public _ExperienceComponentPartial(PortfolyoSitemDbContext context)
        {
            _context = context;
        }
        public Microsoft.AspNetCore.Mvc.IViewComponentResult Invoke()
        {
            var values = _context.ExperiencesTables.ToList();
            return View(values);
        }
    }
}
