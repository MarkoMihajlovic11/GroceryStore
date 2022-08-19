using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;


namespace GroceryStore.Models
{
    public static class SeedData
    {

        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Potato",
                        Description = "A potato is a vegetable",
                        Category = "Vegetable",
                        Price = 1
                    },
                    new Product
                    {
                        Name = "Tomato",
                        Description = "Very nice vegetable",
                        Category = "Vegetable",
                        Price = 3
                    },
                    new Product
                    {
                        Name = "Banana",
                        Description = "Bananas are one of the most popular fruits worldwide",
                        Category = "Fruits",
                        Price = 2
                    },
                    new Product
                    {
                        Name = "Bread",
                        Description = "Bread is a staple food prepared from a dough of flour and water",
                        Category = "Grain product",
                        Price = 5
                    },
                    new Product
                    {
                        Name = "Milk",
                        Description = "Milk is a nutrient-rich liquid food produced by the mammary glands of mammals",
                        Category = "Dairy food",
                        Price = 7
                    },
                    new Product
                    {
                        Name = "Heinz Ketchup",
                        Description = "Best product of tomato",
                        Category = "Table condiment",
                        Price = 2
                    },
                    new Product
                    {
                        Name = "Cheese",
                        Description = "Produced in wide ranges of flavors",
                        Category = "Dairy food",
                        Price = 11
                    },
                    new Product
                    {
                        Name = "Ice Cream",
                        Description = "Very interesting flavours of cold desserts",
                        Category = "Frozen dairy food",
                        Price = 7
                    },
                    new Product
                    {
                        Name = "Pasta",
                        Description = "A dish originally from Italy",
                        Category = "Grain product",
                        Price = 9
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
