using Facebook.ApiClient.Entities.Enumerations;
using Newtonsoft.Json;
using RestSharp.Deserializers;
using System.Collections.Generic;

namespace Facebook.ApiClient.Entities.Api
{
    /// <summary>
    /// type=adgeolocation&location_types=["city"]'
    /// https://developers.facebook.com/docs/marketing-api/audiences/reference/targeting-search#geo
    /// </summary>
    public class CityLocation : GeoLocation
    {
        /// <summary>
        /// Region
        /// </summary>
        [DeserializeAs(Name = "region")]
        [JsonProperty(PropertyName = "region", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Region { get; set; }

        /// <summary>
        /// RegionId
        /// </summary>
        [DeserializeAs(Name = "region_id")]
        [JsonProperty(PropertyName = "region_id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public int RegionId { get; set; }
    }
}