
var builder = WebApplication.CreateBuilder(args);


var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapDinner();
app.MapAuthentication();





app.Run();
