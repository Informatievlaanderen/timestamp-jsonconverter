namespace Be.Vlaanderen.Basisregisters.Converters.Timestamp
{
    using Newtonsoft.Json.Converters;

    public class TimestampConverter : IsoDateTimeConverter
    {
        public TimestampConverter()
            => DateTimeFormat = "yyyy-MM-ddTHH:mm:ssZ";
    }
}
