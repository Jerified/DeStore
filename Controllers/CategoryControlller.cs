using Microsoft.AspNetCore.Mvc;
using MVCProject.Models;

namespace MVCProject.Controllers
{
    public class CategoryController : Controller
  {
    public IActionResult Index()
    {
      return View( );
    }
     public IActionResult Edit(int? id)
        {
            var category = new Category {CategoryId = id.HasValue? id.Value : 0};
            return View(category);
            // if (id.HasValue) 
            //     return new ContentResult { Content = id.ToString()};
            // else
            //     return new ContentResult { Content = "null content" };
        }
  }
}
