using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.Controllers
{
    public class AddressController : Controller
    {
        public readonly IAddressService _addressService;

        public AddressController(IAddressService addressService)
        {
            _addressService = addressService;
        }

        public IActionResult Index()
        {
            var values = _addressService.GetListAll();
            return View(values);
        }
        //[HttpGet]
        //public IActionResult AddAddress() 
        //{
        //    return View();
        //}
        //[HttpPost]
        //public IActionResult AddAddress(Address address)
        //{
        //    _addressService.Insert(address);
        //    return RedirectToAction("Index");
        //}
        //public IActionResult DeleteAddress(int id) 
        //{
        //    var values = _addressService.GetById(id);
        //    _addressService.Delete(values);
        //    return RedirectToAction("Index");
        //}
        [HttpGet]
        public IActionResult EditAddress(int id)
        {
            var values = _addressService.GetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditAddress(Address address)
        {
            AddressValidator validator = new AddressValidator();
            ValidationResult result = validator.Validate(address);
            if (result.IsValid)
            {
                _addressService.Update(address);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}
