using Microsoft.AspNetCore.Mvc;

namespace PortfolyoSitem.ViewComponents.ProjectComponentPartial
{
    public class _ProjectComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
