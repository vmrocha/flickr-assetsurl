using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Text;
using System.Web.Mvc;

namespace FlickrAssetsUrl.Controllers
{
    public class BaseController : Controller
    {
        static BaseController()
        {
            JsonSettings = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                Formatting = Formatting.Indented
            };
        }

        private static JsonSerializerSettings JsonSettings { get; set; }

        protected ActionResult JsonCamelCase(object model)
        {
            return new ContentResult
            {
                ContentType = "application/json",
                Content = JsonConvert.SerializeObject(model, JsonSettings),
                ContentEncoding = Encoding.UTF8
            };
        }
    }
}