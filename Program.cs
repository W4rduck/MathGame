var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/Index.html",() =>"");

app.Run();
