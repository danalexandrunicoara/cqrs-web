using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]/[action]")]
public class ProductController : ControllerBase
{
    private readonly IQueryDispatcher<GetProductsByNameQuery> _queryDispatcher;
    private readonly ICommandDispatcher<AddProductCommand> _commandDispatcher;

    public ProductController(
        IQueryDispatcher<GetProductsByNameQuery> queryDispatcher, 
        ICommandDispatcher<AddProductCommand> commandDispatcher) 
    => (_queryDispatcher, _commandDispatcher) 
    = (queryDispatcher, commandDispatcher);

    [HttpGet]
    public IActionResult GetProductByName(string name)
    {
        GetProductsByNameQuery getProductsByNameQuery = new();
        getProductsByNameQuery.Name = name;
        return Ok(_queryDispatcher.Send(getProductsByNameQuery));
    }
    [HttpGet]
    public IActionResult Test()
    {
        return Ok();
    }
    [HttpPost]
    public IActionResult AddProduct(AddProductCommand command)
    {
        return Ok(_commandDispatcher.Send(command));
    }
}