namespace eShop.Web.ViewModels.Home
{
    public class IndexViewModel
    {
        public string Id { get; set; } = null!;

        public string Name { get; set; } = null!;

        public string ImagePath { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string? Price { get; set; }
    }
}
