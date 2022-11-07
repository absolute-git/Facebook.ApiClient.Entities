using Facebook.ApiClient.Entities.Enumerations;
using Newtonsoft.Json;
using RestSharp.Deserializers;
using System.Collections.Generic;

namespace Facebook.ApiClient.Entities.Api
{

    public class RegionLocation : GeoLocation
    {
        /// <summary>
        /// Country
        /// </summary>
        [DeserializeAs(Name = "country")]
        [JsonProperty(PropertyName = "country", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Country { get; set; }
    }
}