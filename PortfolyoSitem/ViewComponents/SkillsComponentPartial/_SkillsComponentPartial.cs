using Microsoft.AspNetCore.Mvc;
using PortfolyoSitem.Data;

namespace PortfolyoSitem.ViewComponents.SkillsComponentPartial
{
    public class _SkillsComponentPartial : ViewComponent
    {
        private readonly PortfolyoSitemDbContext _context;
        public _SkillsComponentPartial(PortfolyoSitemDbContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var values = _context.SkillsTables.ToList();
            return View(values);
        }
    }
}
