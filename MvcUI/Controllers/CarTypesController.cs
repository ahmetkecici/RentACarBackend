using Dal.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace MvcUI.Controllers;

public class CarTypesController : Controller
{
    public IActionResult GetAll()
    {
        EfCarTypeDal carTypesDal = new EfCarTypeDal();
        var json = JsonConvert.SerializeObject(carTypesDal.GetAll());
        return Json(json);


    }
}