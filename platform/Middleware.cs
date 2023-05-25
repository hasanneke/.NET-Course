namespace Platform
{

    public class QueryStringMiddleWare
    {
        private RequestDelegate next;

        public QueryStringMiddleWare(RequestDelegate nextDelegate)
        {
            next = nextDelegate;
        }

        public async Task Invoke(HttpContext context)
        {
            if (context.Request.Method == HttpMethod.Get.Method
    && context.Request.Query["custom"] == "true")
            {
                context.Response.ContentType = "text/plain";
                await context.Response.WriteAsync("Class Based Custom Middleware \n");
            }
            await next(context);
        }
    }
}