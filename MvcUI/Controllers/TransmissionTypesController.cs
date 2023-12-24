using Dal.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace MvcUI.Controllers;

public class TransmissionTypesController : Controller
{
    public IActionResult GetAll()
    {
        EfTransmissionTypeDal brandsDal = new EfTransmissionTypeDal();
        var json = JsonConvert.SerializeObject(brandsDal.GetAll());
        return Json(json);


    }
}