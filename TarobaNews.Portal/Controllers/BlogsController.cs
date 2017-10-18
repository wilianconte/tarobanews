using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TarobaNews.Portal.Controllers
{
  public class BlogsController : Controller
  {
    [Route("blogs")]
    public IActionResult Blogs()
    {
      return View("Index");
    }
  }
}