namespace BuberDinner.Api.Endpoints;

public static class AuthenticationEndpoint
{
    public static WebApplication MapAuthentication(this WebApplication app)
    {
        var authRoute = app.MapGroup("/auth");

        authRoute.MapPost("/register", (RegisterRequest request) => {
            
            return Ok(request);
        });
        authRoute.MapPost("/login", (LoginRequest request) => {

            return Ok(request);
        });

        return app;
    }
}
