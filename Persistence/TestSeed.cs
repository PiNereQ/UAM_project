using Domain;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace Persistence
{
    public class TestSeed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.Products.Any()) return;
            var categorys = new List<Category>
            {
                new Category
                {
                    Name = "Toy"
                },
                new Category
                {
                    Name = "School"
                }
            };



            var products = new List<Product>
            {
                new Product
                {
                    Title = "Ball",
                    Description = "Small round toy",
                    isDeleted = false,
                    creationDate = DateTime.UtcNow.AddDays(-15),
                    imageUrl = ".",
                },
                new Product
                {
                    Title = "Book",
                    Description = "Papers with some story",
                    isDeleted = false,
                    creationDate = DateTime.UtcNow.AddDays(23),
                    imageUrl = ".",
                },
                new Product
                {
                    Title = "Pen",
                    Description = "Simple stick, used to write smthng on paper",
                    isDeleted = false,
                    creationDate = DateTime.UtcNow.AddDays(-34),
                    imageUrl = ".",
                }
            };

            await context.Products.AddRangeAsync(products);
            await context.Categories.AddRangeAsync(categorys);
            await context.SaveChangesAsync();
        }        
    }
}