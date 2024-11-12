using Carter;

namespace Catalog.API.Products.CreateProduct;

public record class CreateProductRequest(string Name, List<string> Category, string Description, string ImageFile, decimal Price);

public record class CreateProductResponse(Guid Id);

public class CreateProductEndpoint : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        throw new NotImplementedException();
    }
}
