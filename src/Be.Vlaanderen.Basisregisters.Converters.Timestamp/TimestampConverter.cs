namespace Be.Vlaanderen.Basisregisters.Converters.Timestamp
{
    using System.Globalization;
    using Newtonsoft.Json.Converters;

    public class TimestampConverter : IsoDateTimeConverter
    {
        public TimestampConverter()
        {
            DateTimeFormat = "yyyy-MM-ddTHH:mm:ssZ";
            DateTimeStyles = DateTimeStyles.AdjustToUniversal;
        }
    }
}
