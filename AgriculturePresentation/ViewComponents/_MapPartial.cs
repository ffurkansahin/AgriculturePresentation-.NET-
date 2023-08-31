using DataAccessLayer.Contexts;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AgriculturePresentation.ViewComponents
{
    public class _MapPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            AgricultureContext context = new AgricultureContext();
            var values = context.Addresses.Select(i=>i.MapInfo).FirstOrDefault();
            ViewBag.v=values;
            return View();
        }
    }
}
