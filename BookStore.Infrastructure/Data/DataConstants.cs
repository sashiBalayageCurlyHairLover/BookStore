namespace BookStore.Infrastructure.Data
{
    public static class DataConstants
    {
        public const int MinBookTitleLength = 5;
        public const int MaxBookTitleLength = 30;

        public const string ISBNPattern = @"^(97(8|9))?\d{9}(\d|X)$";

        public const double MinBookPrice = 0.01;
        public const double MaxBookPrice = 100;

        public const int MinOrderQuantity = 1;
        public const int MaxOrderQuantity = 100;

        public const int MinAuthorNameLength = 2;
        public const int MaxAuthorNameLength = 25;
    }
}
