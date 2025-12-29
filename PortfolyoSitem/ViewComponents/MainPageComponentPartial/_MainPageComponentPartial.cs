using Microsoft.AspNetCore.Mvc;

namespace PortfolyoSitem.ViewComponents.MainPageComponentPartial
{
    public class _MainPageComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
