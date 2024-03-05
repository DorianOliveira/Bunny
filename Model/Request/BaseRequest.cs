using System.Linq;
using System.Net.Http;
using System.Text;

namespace Kyrios.BunnyStream.Model.Request
{
    public class BaseRequest
    {
        public StringContent ToStringContent()
        {
            var data = "";

            var properties = GetType().GetProperties().Where(x => x.GetValue(this) != null);

            foreach (var property in properties)
            {
                var value = System.Web.HttpUtility.JavaScriptStringEncode(property.GetValue(this).ToString());
                var key = property.Name.ToLower();

                if (!string.IsNullOrEmpty(data))
                    data += ",";
                data += $"\"{key}\":\"{value}\"";
            }

            return new StringContent("{" + data + "}", Encoding.UTF8, "application/json");
        }
    }
}
