using System;
using System.Globalization;
using Newtonsoft.Json;

namespace UserCom.Serialization
{
    public class DateOnlyConverter : JsonConverter<DateTime?>
    {
        public static readonly string Format = "yyyy-MM-dd";

        public override void WriteJson(JsonWriter writer, DateTime? value, JsonSerializer serializer)
        {
            if (value.HasValue)
            {
                writer.WriteValue($"{value.Value.Year:D4}-{value.Value.Month:D2}-{value.Value.Day:D2}");
            }
            else
            {
                writer.WriteNull();
            }
        }

        public override DateTime? ReadJson(JsonReader reader, Type objectType, DateTime? existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            if (reader.Value == null)
            {
                return null;
            }

            return DateTime.ParseExact(reader.Value.ToString()!, Format, CultureInfo.InvariantCulture, DateTimeStyles.None);
        }
    }
}
