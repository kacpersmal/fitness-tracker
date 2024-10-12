using Carter;

namespace FitnessTracker.Api.Features;

public class IdentityEndpoints : ICarterModule
{
    const string ResourceEndpoint = "/identity";
    private const string ResourceName = "Identity";
    
    public IdentityEndpoints() { }
    
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        var _ = app.MapGroup(ResourceEndpoint)
                .WithTags(ResourceName)
                .WithOpenApi() 
            ;        
        _.MapGet("", async() => "Hello World!" );
    }
}