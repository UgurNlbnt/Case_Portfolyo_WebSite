using Microsoft.AspNetCore.Mvc;

namespace PortfolyoSitem.ViewComponents.SkillsComponentPartial
{
    public class _SkillsComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
