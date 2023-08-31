using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AgriculturePresentation.ViewComponents
{
	public class _AnnouncementPartial : ViewComponent
	{
		public readonly IAnnouncementService _announcementService;

		public _AnnouncementPartial(IAnnouncementService announcementService)
		{
			_announcementService = announcementService;
		}

		public IViewComponentResult Invoke()
		{
			List<Announcement> announcements = new List<Announcement>();
			List<Announcement> StatusTrueAnnouncements = new List<Announcement>();
			announcements = _announcementService.GetListAll();
			foreach (var item in announcements)
			{
				if (item.Status == true)
				{
					StatusTrueAnnouncements.Add(item);
				}
			}
			return View(StatusTrueAnnouncements);
		}
	}
}
