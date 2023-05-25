namespace Platform.Services
{
    public static class TypeBroker
    {
        private static IResponseFormatter textFormatter = new TextResponseFormatter();
        private static IResponseFormatter numberFormatter = new NumberResponseFormatter();
        private static IResponseFormatter booleanFormatter = new BooleanResponseFormatter();

        public static IResponseFormatter TextFormatter => textFormatter;
        public static IResponseFormatter NumberFormatter => textFormatter;
        public static IResponseFormatter BooleanFormatter => booleanFormatter;
    }
}