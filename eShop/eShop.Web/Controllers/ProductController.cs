namespace eShop.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
