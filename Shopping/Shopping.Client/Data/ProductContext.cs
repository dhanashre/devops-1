using Shopping.Client.Models;

namespace Shopping.Client.Data
{
    public static class  ProductContext
    {
        public static readonly List<Product> Products = new List<Product>
        {

            new Product()
            {
                Name = "Iphone x",
                Description = "new iphone",
                ImageFile = "product-1.png",
                Price = 70000,
                Category = "Smart phone"
            },

            new Product()
            {
                Name = "android",
                Description = "new iphone",
                ImageFile = "product-1.png",
                Price = 80000,
                Category = "Smart phone"
            },
            new Product()
            {
                Name = "Xiamio Mi 9",
                Description = "new iphone",
                ImageFile = "product-1.png",
                Price = 47000,
                Category = "White Appliances"
            },
            new Product()
            {
                Name = "LG g7 fridge",
                Description = "new iphone",
                ImageFile = "product-1.png",
                Price = 80000,
                Category = "Home Kitchen"
            }
        };
    }
}
