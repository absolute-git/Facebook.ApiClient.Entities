using System;
using System.Collections.Generic;
using System.Linq;
using Facebook.ApiClient.Entities.Enumerations;
using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace Facebook.ApiClient.Entities.Api
{
    /// <inheritdoc />
    /// <summary>
    /// An preview of the Ad as generated.  In the form of an HTML IFrame
    /// </summary>
    public class AdPreview : BaseEntity
    {
        /// <summary>
        /// The body of HTML, an iframe
        /// </summary>
        [DeserializeAs(Name = "body")]
        [JsonProperty(PropertyName = "body", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string PreviewIframeHtml { get; set; }

        /// <summary>
        /// Get api field selectors for <see cref="AdPreview"/>
        /// </summary>
        /// <returns>Comma seperated fields</returns>
        public static IList<string> GetApiSelectors()
        {
            var apiFields = typeof(AdPreview).GetProperties()
                .Select(e => e.GetCustomAttributes(typeof(DeserializeAsAttribute), true)).Where(e => e.Length > 0)
                .Select(e => e.First() as DeserializeAsAttribute).Where(e => e != null).Select(e => e.Name).ToList();

            return apiFields;
        }
    }
}
