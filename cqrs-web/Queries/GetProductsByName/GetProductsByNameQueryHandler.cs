public class GetProductsByNameCommandHandler : IQueryHandler<GetProductsByNameQuery>
{
    private readonly IProductData _productData;
    public GetProductsByNameCommandHandler(IProductData productData) => _productData = productData;

    IEnumerable<IQueryResult> IQueryHandler<GetProductsByNameQuery>.Handle(GetProductsByNameQuery query)
    {
        return _productData.Products.Where(p => p.Name == query.Name)
                .Select(p => new ProductDisplayByName { Name = p.Name });
    }
}