using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace BusinessTraining
{
    internal static class SerializationHelper
    {
        public static string Serialize<TValue>(TValue value)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.All)
            };
            return JsonSerializer.Serialize(value, options);
        }
    }
}
