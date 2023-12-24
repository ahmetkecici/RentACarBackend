using Dal.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace MvcUI.Controllers;

public class ColorsController : Controller
{
    public IActionResult GetAll()
    {
        EfColorDal colorDal = new EfColorDal();
        var json = JsonConvert.SerializeObject(colorDal.GetAll());
        return Json(json);


    }
}