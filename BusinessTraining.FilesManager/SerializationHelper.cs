using System.IO;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace BusinessTraining.FilesManager
{
    public static class SerializationHelper
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

        public static TValue Deserialize<TValue>(Stream utf8Json)
        {
            var options = new JsonSerializerOptions
            {
                DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
            };
            return JsonSerializer.Deserialize<TValue>(utf8Json, options);
        }

        public static TValue Deserialize<TValue>(string json)
        {
            var options = new JsonSerializerOptions
            {
                DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
            };
            return JsonSerializer.Deserialize<TValue>(json, options);
        }
    }
}
