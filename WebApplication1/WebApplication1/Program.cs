var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
var app = builder.Build();

//app.MapGet("/", () => "Hello World! this is  my first application");
app.MapRazorPages();

app.Run();
