using Dal.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace MvcUI.Controllers;

public class CurrenciesController : Controller
{
    public IActionResult GetAll()
    {
        EfCurrencyDal currencyDal = new EfCurrencyDal();
        var json = JsonConvert.SerializeObject(currencyDal.GetAll());
        return Json(json);


    }
}