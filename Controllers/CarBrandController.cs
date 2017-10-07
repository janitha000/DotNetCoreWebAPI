using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
public class CarBrandController : Controller
{

    [HttpGet]
    public IEnumerable<string> Get()
    {
        CarBrandManager manager = new CarBrandManager();
        ICarBrand brand = manager.GetBrand("Toyota");
        return brand.GetTypes();
    }
}