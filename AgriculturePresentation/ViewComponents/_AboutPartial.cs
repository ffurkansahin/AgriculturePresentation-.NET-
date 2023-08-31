using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.ViewComponents
{
	public class _AboutPartial : ViewComponent
	{
		public readonly IAboutService _aboutService;

		public _AboutPartial(IAboutService aboutService)
		{
			_aboutService = aboutService;
		}

		public IViewComponentResult Invoke()
		{
			var value = _aboutService.GetListAll();
			return View(value);
		}
	}
}
