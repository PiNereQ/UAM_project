using Domain;

namespace Persistence
{
    public class TestSeed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.Products.Any()) return;

            var products = new List<Product>
            {
                new Product
                {
                    Title = "Ball",
                    Description = "Small round toy",
                    isDeleted = false,
                    creationDate = DateTime.UtcNow.AddDays(-15),
                    imageUrl = "",
                },
                new Product
                {
                    Title = "Book",
                    Description = "Papers with some story",
                    isDeleted = false,
                    creationDate = DateTime.UtcNow.AddDays(23),
                    imageUrl = "",
                },
                new Product
                {
                    Title = "Ball",
                    Description = "Small round toy",
                    isDeleted = false,
                    creationDate = DateTime.UtcNow.AddDays(15),
                    imageUrl = "",
                }
            };

            await context.Products.AddRangeAsync(products);
            await context.SaveChangesAsync();
        }        
    }
}