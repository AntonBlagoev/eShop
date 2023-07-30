namespace eShop.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using Infrastructure.Extensions;
    using Services.Data.Interfaces;
    using Services.Data.Models.Product;
    using ViewModels.Product;
    using eShop.Common;


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
        public async Task<IActionResult> All([FromQuery] AllProductsQueryModel queryModel)
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

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Details(string id)
        {
            bool productExist = await this.productService.ExistByIdAsync(id);

            if (!productExist)
            {
                return this.NotExistError();
            }

            ProductDetailsViewModel? viewModel = await this.productService.ProductDetailsAsync(id);

            return View(viewModel);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            bool productExist = await this.productService.ExistByIdAsync(id);

            if (!productExist)
            {
                return this.NotExistError();
            }

            try
            {
                ProductFormModel formModel = await this.productService.GetProductEditByIdAsync(id);
                formModel.Categories = await this.categoryService.AllCategoriesAsync();

                return this.View(formModel);
            }
            catch (Exception)
            {
                return this.UnexpectedError();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(string id, ProductFormModel model)
        {
            if (!this.ModelState.IsValid)
            {
                model.Categories = await this.categoryService.AllCategoriesAsync();
                return this.View(model);
            }

            bool productExists = await this.productService.ExistByIdAsync(id);
            if (!productExists)
            {
                return this.NotExistError();
            }

            try
            {
                await this.productService.EditProductByIdAndFormModelAsync(id, model);
            }
            catch (Exception)
            {
                this.ModelState.AddModelError(string.Empty, "Unexpected error occurred while trying to update the product. Please try again later!");
                model.Categories = await this.categoryService.AllCategoriesAsync();

                return this.View(model);
            }

            this.TempData["SuccessMessage"] = "Product was edited successfully!";
            return this.RedirectToAction("Details", "Product", new { id });
        }


        private IActionResult UnexpectedError()
        {
            this.TempData["ErrorMessage"] = "Unexpected error occurred! Please try again later!";
            return this.RedirectToAction("Index", "Home");
        }
        private IActionResult NotExistError()
        {
            this.TempData["ErrorMessage"] = "Product does not exist!";
            return this.RedirectToAction("All", "Product");
        }

    }
}
