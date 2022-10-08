using Facebook.ApiClient.Entities.Enumerations;
using Newtonsoft.Json;
using RestSharp.Deserializers;
using System.Collections.Generic;

namespace Facebook.ApiClient.Entities.Api
{
    /// <summary>
    /// type=adgeolocation&
    /// location_types=["country","region","geo_market"]
    /// 
    /// https://developers.facebook.com/docs/marketing-api/audiences/reference/targeting-search#geo
    /// </summary>
    public class GeoLocation : BaseEntity
    {
        /// <summary>
        /// Key
        /// </summary>
        [DeserializeAs(Name = "key")]
        [JsonProperty(PropertyName = "key", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Key { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [DeserializeAs(Name = "name")]
        [JsonProperty(PropertyName = "name", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Name { get; set; }

        /// <summary>
        /// Type
        /// </summary>
        [DeserializeAs(Name = "type")]
        [JsonProperty(PropertyName = "type", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Type { get; set; }

        /// <summary>
        /// CountryCode
        /// </summary>
        [DeserializeAs(Name = "country_code")]
        [JsonProperty(PropertyName = "country_code", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public virtual string CountryCode { get; set; }

        /// <summary>
        /// CountryName
        /// </summary>
        [DeserializeAs(Name = "country_name")]
        [JsonProperty(PropertyName = "country_name", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string CountryName { get; set; }

        /// <summary>
        /// SupportsCity
        /// </summary>
        [DeserializeAs(Name = "supports_city")]
        [JsonProperty(PropertyName = "supports_city", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public bool SupportsCity { get; set; }

        /// <summary>
        /// SupportsRegion
        /// </summary>
        [DeserializeAs(Name = "supports_region")]
        [JsonProperty(PropertyName = "supports_region", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public bool SupportsRegion { get; set; }

        /// <summary>
        /// GeoHierarchyLevel
        /// </summary>
        [DeserializeAs(Name = "geo_hierarchy_level")]
        [JsonProperty(PropertyName = "geo_hierarchy_level", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public GeographicAreas? GeoHierarchyLevel { get; set; }

        /// <summary>
        /// GeoHierarchyName
        /// </summary>
        [DeserializeAs(Name = "geo_hierarchy_name")]
        [JsonProperty(PropertyName = "geo_hierarchy_name", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string GeoHierarchyName { get; set; }

        /// <summary>
        /// Paging
        /// </summary>
        [DeserializeAs(Name = "paging")]
        [JsonProperty(PropertyName = "paging", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public Paging Paging { get; set; }
    }
}