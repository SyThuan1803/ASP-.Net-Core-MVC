using Microsoft.AspNetCore.Mvc;
using RestAPI_Project_BookWeb.Data;
using RestAPI_Project_BookWeb.Models;

namespace RestAPI_Project_BookWeb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Category> objCategoryList=_db.Categories;

            return View(objCategoryList);
        }
    }
}
