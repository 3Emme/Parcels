using Microsoft.AspNetCore.Mvc;

namespace Parcel.Controllers
{
  public class HomeController : HomeController
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}