using Serilog;

var builder = WebApplication.CreateBuilder(args);
builder.Host.UseSerilog((ctx, lc) => lc
    .WriteTo.Console()
    .WriteTo.Seq("http://localhost:5555"));
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();


