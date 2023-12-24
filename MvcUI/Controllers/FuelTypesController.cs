using Dal.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace MvcUI.Controllers;

public class FuelTypesController : Controller
{
    public IActionResult GetAll()
    {
        EfFuelTypeDal fuelTypeDal = new EfFuelTypeDal();
        var json = JsonConvert.SerializeObject(fuelTypeDal.GetAll());
        return Json(json);


    }
}