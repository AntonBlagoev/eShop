namespace eShop.Common
{
    public static class EntityValidationConstants
    {
        public static class Category
        {
            public const int NameMinLength = 1;
            public const int NameMaxLength = 50;

            public const int DescriptionMaxLength = 400;
        }

        public static class Product
        {
            public const int NameMinLength = 1;
            public const int NameMaxLength = 50;

            public const int DescriptionMinLength = 10;
            public const int DescriptionMaxLength = 2000;

            public const int ImageUrlMinLength = 4;
            public const int ImageUrlMaxLength = 200;


            public const int WarrantyMinValue = 0;
            public const int WarrantyMaxValue = 60;

            public const string PriceMinValue = "0";
            public const string PriceMaxValue = "10000";
            public const string PriceRegExValidator = @"^\$?\d+(\.(\d{2}))?$";


        }

        public static class Review
        {
            public const int TitleMinLength = 2;
            public const int TitleMaxLength = 50;

            public const int ContentMaxLength = 500;

            public const int ImageUrlMaxLength = 200;
        }


        public static class CartItem
        {
            public const int QuantityMinValue = 0;
            public const int QuantityMaxValue = 100;

        }

        public static class Order
        {
            public const int NoteMaxLength = 200; 

        }
        public static class OrderItem
        {
            public const int QuantityMinValue = 0;
            public const int QuantityMaxValue = 100;

        }

        public static class ApplicationUser
        {
            public const int FirstNameMinLength = 1;
            public const int FirstNameMaxLength = 15;

            public const int LastNameMinLength = 1;
            public const int LastNameMaxLength = 15;

            public const int AddressMinLength = 1;
            public const int AddressMaxLength = 150;

            public const int CityMinLength = 1;
            public const int CityMaxLength = 20;

            public const int PostalCodeMinLength = 1;
            public const int PostalCodeMaxLength = 4;
        }
    }
}