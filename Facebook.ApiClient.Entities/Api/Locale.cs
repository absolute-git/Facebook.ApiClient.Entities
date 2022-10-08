using Facebook.ApiClient.Entities.Enumerations;
using Newtonsoft.Json;
using RestSharp.Deserializers;
using System.Collections.Generic;

namespace Facebook.ApiClient.Entities.Api
{
    /// <summary>
    /// type=adlocale
    /// https://developers.facebook.com/docs/marketing-api/audiences/reference/targeting-search#locale
    /// </summary>
    public class Locale : BaseEntity
    {
        /// <summary>
        /// Region
        /// </summary>
        [DeserializeAs(Name = "name")]
        [JsonProperty(PropertyName = "name", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Name { get; set; }

        /// <summary>
        /// Key
        /// </summary>
        [DeserializeAs(Name = "key")]
        [JsonProperty(PropertyName = "key", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public int Key { get; set; }

        /// <summary>
        /// Paging
        /// </summary>
        [DeserializeAs(Name = "paging")]
        [JsonProperty(PropertyName = "paging", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public Paging Paging { get; set; }
    }
}