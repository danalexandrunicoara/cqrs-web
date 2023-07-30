public class ProductData : IProductData
{
    public IList<Product> Products { get; set; } =
    new List<Product> {
        new Product {
            Id = Guid.NewGuid(),
            Name = "Product name 1",
            Description = "Product description 1"
        },
        new Product {
            Id = Guid.NewGuid(),
            Name = "Product name 2",
            Description = "Product description 2"
        },
        new Product {
            Id = Guid.NewGuid(),
            Name = "Product name 3",
            Description = "Product description 3"
        }
    };
}