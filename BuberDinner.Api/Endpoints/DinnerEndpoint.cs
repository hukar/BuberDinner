namespace BuberDinner.Api.Endpoints;

public static class DinnerEndpoint
{
    public static WebApplication MapDinner(this WebApplication app)
    {
        var RouteDinner = app.MapGroup("/dinner");

        RouteDinner.MapGet("/", () => {

            return Ok(new { Message = "All is cool", Id = Guid.NewGuid() });
        });


        return app;
    }
}
