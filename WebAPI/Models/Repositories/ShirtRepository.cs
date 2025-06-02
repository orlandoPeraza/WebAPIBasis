namespace WebAPI.Models.Repositories
{
    public static class ShirtRepository
    {
        private static List<Shirt> shirts = new List<Shirt>()
        {
            new Shirt {ShirtId = 1, Brand = "My Brand 1", Color = "red", Gender = "men", Price = 150, Size = 9},
            new Shirt {ShirtId = 2, Brand = "My Brand 2", Color = "blu", Gender = "women", Price = 150, Size = 5},
            new Shirt {ShirtId = 3, Brand = "My Brand 3", Color = "green", Gender = "men", Price = 150, Size = 7},
            new Shirt {ShirtId = 4, Brand = "My Brand 4", Color = "orange", Gender = "women", Price = 150, Size = 6},
            new Shirt {ShirtId = 5, Brand = "My Brand 5", Color = "yellow", Gender = "men", Price = 150, Size = 11},
        };

        public static bool ShirtExist(int id)
        {
            return shirts.Any(x => x.ShirtId == id);
        }

        public static Shirt? GetShirtById(int id)
        {
            return shirts.FirstOrDefault(x => x.ShirtId == id);
        }
    }
}
