
using Catalog.API.Products.GetProductById;

namespace Catalog.API.Products.GetProductByCategory;

// public record GetProductsByCateforyRequest();
public record GetProductsByCateforyResponse(IEnumerable<Product> Products);

public class GetProductByCategoryEndpoint : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("/products/category/{category}", async (string category, ISender sender) =>
        {
            var result = await sender.Send(new GetProductByCategoryQuery(category));
            var response = result.Adapt<GetProductsByCateforyResponse>();

            return Results.Ok(response);
        })
        .WithName("GetProductByCategory")
        .Produces<GetProductsByCateforyResponse>(StatusCodes.Status200OK)
        .ProducesProblem(StatusCodes.Status404NotFound)
        .WithSummary("Get Product By Category")
        .WithDescription("Get a product by Category");
    }
}
