namespace WebAPI.Models.Repositories
{
    public static class ShirtRepository
    {
        private static List<Shirt> shirts = new List<Shirt>()
        {
            new Shirt {ShirtId = 1, Brand = "My Brand 1", Color = "red", Gender = "men", Price = 150, Size = 9},
            new Shirt {ShirtId = 2, Brand = "My Brand 2", Color = "blue", Gender = "women", Price = 150, Size = 7},
            new Shirt {ShirtId = 3, Brand = "My Brand 3", Color = "green", Gender = "men", Price = 150, Size = 8},
            new Shirt {ShirtId = 4, Brand = "My Brand 4", Color = "orange", Gender = "women", Price = 150, Size = 6},
            new Shirt {ShirtId = 5, Brand = "My Brand 5", Color = "yellow", Gender = "men", Price = 150, Size = 11},
        };

        public static List<Shirt> GetShirts()
        {
            return shirts;
        }

        public static bool ShirtExist(int id)
        {
            return shirts.Any(x => x.ShirtId == id);
        }

        public static Shirt? GetShirtById(int id)
        {
            return shirts.FirstOrDefault(x => x.ShirtId == id);
        }

        public static Shirt? GetShirtByProperties(string? brand, string? gender, string? color, int? size)
        {
            return shirts.FirstOrDefault(x =>
            !string.IsNullOrWhiteSpace(brand) &&
            !string.IsNullOrWhiteSpace(x.Brand) &&
            x.Brand.Equals(brand, StringComparison.OrdinalIgnoreCase) &&
            !string.IsNullOrWhiteSpace(gender) &&
            !string.IsNullOrWhiteSpace(x.Gender) &&
            x.Gender.Equals(gender, StringComparison.OrdinalIgnoreCase) &&
            !string.IsNullOrWhiteSpace(color) &&
            !string.IsNullOrWhiteSpace(x.Color) &&
            x.Color.Equals(color, StringComparison.OrdinalIgnoreCase) &&
            size.HasValue &&
            x.Size.HasValue &&
            x.Size.Value == size.Value);
        }

        public static void AddShirt(Shirt shirt)
        {
            int max = shirts.Max(x => x.ShirtId);
            shirt.ShirtId = max + 1;
            shirts.Add(shirt);
        }

        public static void UpdateShirt(Shirt shirt)
        {
            var shirtToUpdate = shirts.First(x => x.ShirtId == shirt.ShirtId);
            shirtToUpdate.Brand = shirt.Brand;
            shirtToUpdate.Price = shirt.Price;
            shirtToUpdate.Size = shirt.Size;
            shirtToUpdate.Color = shirt.Color;
            shirtToUpdate.Gender = shirt.Gender;
        }

        public static void DeleteShirt(int shirtId)
        {
            var shirt = GetShirtById(shirtId);
            if (shirt != null)
            {
                shirts.Remove(shirt);
            }
        }
    }
}
