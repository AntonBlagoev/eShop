namespace eShop.Web.Controllers
{
    using eShop.Services.Data.Interfaces;
    using eShop.Services.Data.Models.Product;
    using eShop.Web.ViewModels.Product;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize]
    public class ProductController : Controller
    {
        private readonly ICategoryService categoryService;
        private readonly IProductService productService;

        public ProductController(ICategoryService categoryService, IProductService productService)
        {
            this.categoryService = categoryService;
            this.productService = productService;

        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> All([FromQuery]AllProductsQueryModel queryModel)
        {
            AllProductsFilteredAndPagedServiceModel serviceModel = await this.productService.AllAsync(queryModel);

            queryModel.Products = serviceModel.Products;
            queryModel.TotalProducts = serviceModel.TotalProductsCount;
            queryModel.Categories = await this.categoryService.AllCategoryNamesAsync();

            return this.View(queryModel);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            ProductFormModel formModel = new ProductFormModel()
            {
                Categories = await this.categoryService.AllCategoriesAsync()
            };

            return View(formModel);
        }

        [HttpPost]
        public async Task<IActionResult> Add(ProductFormModel model)
        {
            bool categoryExist = await this.categoryService.ExistByIdAsync(model.CategoryId);
            if (!categoryExist)
            {
                ModelState.AddModelError(nameof(model.CategoryId), "Selected category does not exst");
            }

            if (!ModelState.IsValid)
            {
                model.Categories = await this.categoryService.AllCategoriesAsync();
                return this.View(model);
            }

            try
            {
                await this.productService.CreateAsync(model);

            }
            catch (Exception)
            {
                this.ModelState.AddModelError(string.Empty, "Unexpexcted error, while trying add product.");
                model.Categories = await this.categoryService.AllCategoriesAsync(); 
                return View(model);
            }

            return RedirectToAction("All", "Product");

        }






    }
}
