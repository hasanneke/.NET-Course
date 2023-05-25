using Platform;
using Platform.Services;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.UseMiddleware<WeatherMiddleware>();

//DEPENDENCY INJECTIOM
builder.Services.AddSingleton<IResponseFormatter, TextResponseFormatter>();

// SINGLETON
app.MapGet("middlware/function", async (context) =>
{
    await TypeBroker.TextFormatter.Format(context, "It is snowing in Chicago");
    await TextResponseFormatter.Singleton.Format(context, "It is snowing in Chicago");
});

app.MapGet("endpoint/class", WeatherEndpoint.Endpoint);

app.MapGet("endpoint/function", async context =>
{
    // Tightly Coupled
    await TypeBroker.NumberFormatter.Format(context, "It is sunny in LA");
});

app.Run();
