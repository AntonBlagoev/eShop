namespace eShop.Common
{
    public static class EntityValidationConstants
    {
        public static class Category
        {
            public const int NameMinLength = 2;
            public const int NameMaxLength = 50;

            public const int DescriptionMinLength = 2;
            public const int DescriptionMaxLength = 200;
        }

        public static class Product
        {
            public const int NameMinLength = 2;
            public const int NameMaxLength = 50;

            public const int DescriptionMinLength = 10;
            public const int DescriptionMaxLength = 2000;

            public const int ImageUrlMaxLength = 200;
        }

        public static class Review
        {
            public const int TitleMinLength = 2;
            public const int TitleMaxLength = 50;

            public const int ContentMaxLength = 500;

            public const int ImageUrlMaxLength = 200;
        }


    }
}