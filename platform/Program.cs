var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// app.Use(async (context, next) =>
// {
//     if (context.Request.Method == HttpMethod.Get.Method
//     && context.Request.Query["custom"] == "true")
//     {
//         context.Response.ContentType = "text/plain";
//         await context.Response.WriteAsync("Custom Middleware \n");
//     }
//     await next();
// });

app.UseMiddleware<Platform.QueryStringMiddleWare>();

app.MapGet("/", () => "Hello World!");
app.Run();
