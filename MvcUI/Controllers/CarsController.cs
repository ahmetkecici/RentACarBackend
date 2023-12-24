using Business.Abstract;
using Business.Concrete;
using Business.Validation.FluentValidation;
using Dal.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MvcUI.Helper;
using Newtonsoft.Json;

namespace MvcUI.Controllers
{
    public class CarsController : Controller
    {
        private ICarService _carService;

        private ImageHelper _helper;
        public CarsController(ICarService carService, ImageHelper helper)
        {
            _carService = carService;
            _helper = helper;
        }
     //   [Authorize("Ahmet")]
        //public IActionResult CarList(CarFilterModel carFilterModel)
        //{
        //   var data =_carService.GetCarDetailList();
        //    return View(data);
        //}
        public IActionResult CarList()
        {
            var data = _carService.GetCarDetailList();
            return View(data);
        }
        //[Authorize(Roles = "caradd")]
        public IActionResult Add()
        {
            CarAddDto carAddDto = new CarAddDto();

            return View(carAddDto);
        }
        [HttpPost]
        public async Task<IActionResult> Add(CarAddDto carAddDto)
        {
            var validator = new CarAddDtoValidator();
            var result = validator.Validate(carAddDto);
            if (result.IsValid)
            {
             var carId=   _carService.Add(carAddDto);
                EfCarImageDal carImageDal = new EfCarImageDal();
                int i = 0;
                foreach (var image in carAddDto.CarImages)
                {
                   var imageAddResult=  await _helper.AddPhotoAsync(image);
                    CarImage imageToAdd = new CarImage
                    {
                        CarId = carId.Id,
                        IsMain = i==0?true:false,
                        Path = imageAddResult.SecureUrl.AbsoluteUri
                    };
                    i++;
                    carImageDal.Add(imageToAdd);
                }

                return RedirectToAction("CarList");
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("All",error.ErrorMessage);
            }
            return View(carAddDto);
        }

        public IActionResult Details(int id)
        {
            var data=_carService.GetCarDetail(id);
            return View(data);
        }

        [HttpPost]
        public IActionResult AddCar(CarAddDto carToadd)
        {
          //  var car = JsonConvert.DeserializeObject<CarAddDto>(carToadd);
          var validator = new CarAddDtoValidator();
         var result= validator.Validate(carToadd);
         if (!result.IsValid)
         {
             return BadRequest(result.Errors);
         }

         
         return Json("Araba Ekleme Başarılı ");
        }
    }
}
