using DataAccessLayer.Contexts;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AgriculturePresentation.ViewComponents
{
    public class _DashboardOverviewPartial : ViewComponent
    {
        AgricultureContext agricultureContext = new AgricultureContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.teamCount = agricultureContext.Teams.Count();
            ViewBag.serviceCount = agricultureContext.Services.Count();
            ViewBag.messageCount = agricultureContext.Contacts.Count();
            ViewBag.CurrentMonthMessage = 3;

            ViewBag.announcementTrue=agricultureContext.Announcements.Where(i=>i.Status==true).Count();
            ViewBag.announcementFalse=agricultureContext.Announcements.Where(i=>i.Status==false).Count();

            ViewBag.urunPazarlama = agricultureContext.Teams.Where(i => i.Title == "Ürün Pazarlama").Select(y => y.PersonName).FirstOrDefault();
            ViewBag.bakliyatYonetimi = agricultureContext.Teams.Where(i => i.Title == "Bakliyat Yönetimi").Select(y => y.PersonName).FirstOrDefault();
            ViewBag.sutUretici = agricultureContext.Teams.Where(i => i.Title == "Süt Üreticisi").Select(y => y.PersonName).FirstOrDefault();
            ViewBag.gubreYonetimi = agricultureContext.Teams.Where(i => i.Title == "Gübre Yönetimi").Select(y => y.PersonName).FirstOrDefault();
            return View();
        }
    }
}
