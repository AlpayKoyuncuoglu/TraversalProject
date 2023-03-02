using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace TraversalCoreProject.ViewComponents.Default
{
    public class _StatisticsPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            using var c = new Context();
            ViewBag.DestinationCount = c.Destinations.Count();
            ViewBag.GuideCount = c.Guides.Count();
            ViewBag.v1 = c.Destinations.Count();
            return View();
        }
    }
}
