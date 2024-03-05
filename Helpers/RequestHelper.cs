using System.Text.Json;

namespace Kyrios.Helpers
{
    public class RequestHelper
    {
        public static T GetObject<T>(string data, string key = "Items")
        {
            try
            {
                var jsonDocument = JsonDocument.Parse(data);
                var items = jsonDocument.RootElement;

                if (!string.IsNullOrEmpty(key))
                    items = jsonDocument.RootElement.GetProperty(key);

                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true,
                };

                return JsonSerializer.Deserialize<T>(items.ToString(), options);
            }
            catch
            {
                return default;
            }
        }

        public static T GetObjectFromRoot<T>(string data) => GetObject<T>(data, "");

    }
}
