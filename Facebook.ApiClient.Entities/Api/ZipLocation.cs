using Facebook.ApiClient.Entities.Enumerations;
using Newtonsoft.Json;
using RestSharp.Deserializers;
using System.Collections.Generic;

namespace Facebook.ApiClient.Entities.Api
{
    /// <summary>
    /// type=adgeolocation&location_types=["zip"]'
    /// https://developers.facebook.com/docs/marketing-api/audiences/reference/targeting-search#geo
    /// </summary>
    public class ZipLocation : CityLocation
    {
        /// <summary>
        /// PrimaryCityId
        /// </summary>
        [DeserializeAs(Name = "primary_city_id")]
        [JsonProperty(PropertyName = "primary_city_id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public long PrimaryCityId { get; set; }

        /// <summary>
        /// RegionId
        /// </summary>
        [DeserializeAs(Name = "primary_city")]
        [JsonProperty(PropertyName = "primary_city", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string PrimaryCity { get; set; }
    }
}