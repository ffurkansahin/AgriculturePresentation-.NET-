using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace AgriculturePresentation.Controllers
{
    public class AnnouncementController : Controller
    {
        public readonly IAnnouncementService _announcemenetService;

        public AnnouncementController(IAnnouncementService announcemenetService)
        {
            _announcemenetService = announcemenetService;
        }

        public IActionResult Index()
        {
            var values = _announcemenetService.GetListAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddAnnouncement() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddAnnouncement(Announcement announcement)
        {
            announcement.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            announcement.Status = false;
            _announcemenetService.Insert(announcement);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteAnnouncement(int id)
        {
            var values = _announcemenetService.GetById(id);
            _announcemenetService.Delete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditAnnouncement(int id)
        {
            var values = _announcemenetService.GetById(id);
            return View(values);

        }
        [HttpPost]
        public IActionResult EditAnnouncement(Announcement announcement)
        {
            _announcemenetService.Update(announcement);
            return RedirectToAction("Index");
        }
        public IActionResult ChangeStatusToTrue(int id)
        {
            _announcemenetService.AnnouncementStatusToTrue(id);
            return RedirectToAction("Index");
        }
        public IActionResult ChangeStatusToFalse(int id)
        {
            _announcemenetService.AnnouncementStatusToFalse(id);
            return RedirectToAction("Index");
        }
    }
}
