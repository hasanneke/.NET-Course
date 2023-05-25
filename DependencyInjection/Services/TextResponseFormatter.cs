namespace Platform.Services
{
    public class TextResponseFormatter : IResponseFormatter
    {
        // SINGLETON PATTERN
        private static TextResponseFormatter? shared;

        public static TextResponseFormatter Singleton
        {
            get
            {
                if (shared == null)
                {
                    shared = new TextResponseFormatter();
                }
                return shared;
            }
        }
        private int responseCounter = 0;

        public async Task Format(HttpContext context, string content)
        {
            await context.Response.WriteAsync($"TextResponseFormatter Response {++responseCounter}:\n{content}");
        }
    }
}