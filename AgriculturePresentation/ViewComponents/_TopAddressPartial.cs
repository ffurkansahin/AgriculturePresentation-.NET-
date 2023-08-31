using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace AgriculturePresentation.ViewComponents
{
    public class _TopAddressPartial : ViewComponent
    {
        private readonly IAddressService addressService;

		public _TopAddressPartial(IAddressService addressService)
		{
			this.addressService = addressService;
		}

		public IViewComponentResult Invoke()
        {
            var value= addressService.GetListAll();
            return View(value);
        }
    }
}
