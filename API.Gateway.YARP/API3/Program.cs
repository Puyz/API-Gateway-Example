var builder = WebApplication.CreateBuilder(args);


var app = builder.Build();

app.MapGet("/api3", () => "API 3");
app.Run();
