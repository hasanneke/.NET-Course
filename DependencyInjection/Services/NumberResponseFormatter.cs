namespace Platform.Services
{
    public class NumberResponseFormatter : IResponseFormatter
    {
        private int responseCounter = 0;

        public async Task Format(HttpContext context, string content)
        {
            await context.Response.WriteAsync($"Number Response Formatter Response {++responseCounter}:\n{content}");
        }
    }
}