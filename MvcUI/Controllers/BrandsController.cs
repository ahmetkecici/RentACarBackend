using Dal.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace MvcUI.Controllers
{
    public class BrandsController : Controller
    {
        public IActionResult GetAll()
        {
            EfBrandDal brandsDal = new EfBrandDal();
            var json = JsonConvert.SerializeObject(brandsDal.GetAll());
            return Json(json);


        }
    }
}
