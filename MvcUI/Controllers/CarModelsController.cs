using Dal.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace MvcUI.Controllers
{
    public class CarModelsController : Controller
    {
        public IActionResult GetCarModels(int brandId)
        {
            EfCarModelDal carModelDal=new EfCarModelDal();
            var json = JsonConvert.SerializeObject(carModelDal.GetAll(x=>x.BrandId==brandId));
            return Json(json);


        }
    }
}
