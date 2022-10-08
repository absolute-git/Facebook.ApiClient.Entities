using Facebook.ApiClient.Entities.Enumerations;
using Newtonsoft.Json;
using RestSharp.Deserializers;
using System.Collections.Generic;

namespace Facebook.ApiClient.Entities.Api
{
    /// <summary>
    /// type=adgeolocation&location_types=["country_group"]'
    /// https://developers.facebook.com/docs/marketing-api/audiences/reference/targeting-search#geo
    /// </summary>
    public class CountryGroupLocation : GeoLocation
    {
        /// <summary>
        /// CountryCodes
        /// </summary>
        [DeserializeAs(Name = "country_codes")]
        [JsonProperty(PropertyName = "country_codes", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<string> CountryCodes { get; set; }

        /// <summary>
        /// IsWorldwide
        /// </summary>
        [DeserializeAs(Name = "is_worldwide")]
        [JsonProperty(PropertyName = "is_worldwide", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public bool IsWorldwide { get; set; }
    }
}