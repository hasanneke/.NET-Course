namespace Platform.Services
{
    public class BooleanResponseFormatter : IResponseFormatter
    {
        private int responseCounter = 0;

        public async Task Format(HttpContext context, string content)
        {
            await context.Response.WriteAsync($"Boolean Response Formatter Response {++responseCounter}:\n{content}");
        }
    }
}