var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<IProductData, ProductData>();

builder.Services.AddScoped<IQueryDispatcher<GetProductsByNameQuery>, QueryDispatcher<GetProductsByNameQuery>>();
builder.Services.AddScoped<IQueryHandler<GetProductsByNameQuery>, GetProductsByNameCommandHandler>();

builder.Services.AddScoped<ICommandDispatcher<AddProductCommand>, CommandDispatcher<AddProductCommand>>();
builder.Services.AddScoped<ICommandHandler<AddProductCommand>, AddProductCommandHandler>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
