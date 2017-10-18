using Microsoft.AspNetCore.Mvc;

namespace TarobaNews.Portal.Controllers
{
  public class EditorialController : Controller
  {
    [Route("noticias")]
    public IActionResult Noticias()
    {
      return View("Index");
    }
  }
}