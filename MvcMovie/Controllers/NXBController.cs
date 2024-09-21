using Microsoft.AspNetCore.Mvc;
namespace MvcMovie.Controllers;
public class NXBController : Controller 


{
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(string fullname, string Address)
    {
        @ViewBag.message =fullname + "-" + Address;
        return View();
        
    }
}
