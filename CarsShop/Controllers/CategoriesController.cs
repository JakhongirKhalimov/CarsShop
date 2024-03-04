using Microsoft.AspNetCore.Mvc;

namespace CarsShop.Controllers
{
    public class CategoriesController(ICategoryService categoryService)
        : Controller
    {
        private readonly ICategoryService categoryService = categoryService;

        public IActionResult Index()
        {
            var categories = categoryService.GetAll();
            return View(categories);
        }
    }
}
