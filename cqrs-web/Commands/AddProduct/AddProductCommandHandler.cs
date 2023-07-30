public class AddProductCommandHandler : ICommandHandler<AddProductCommand>
{
    private readonly IProductData _productData;
    public AddProductCommandHandler(IProductData productData) => _productData = productData;
    public bool Handle(AddProductCommand command)
    {
        _productData.Products.Add(
            new Product { Id = command.Id, Name = command.Name, Description = command.Description }
        );
        return true;
    }
}