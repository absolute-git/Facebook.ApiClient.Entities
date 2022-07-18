using Facebook.ApiClient.Entities.Enumerations;
using Newtonsoft.Json;
using RestSharp.Deserializers;
using System.Collections.Generic;

namespace Facebook.ApiClient.Entities.Api
{
    /// <inheritdoc />
    /// <summary>
    /// Targeting specs are used as part of ad sets to define the type of person the ad will be displayed to.
    /// </summary>
    public class Targeting : BaseEntity
    {
        [DeserializeAs(Name = "age_max")]
        [JsonProperty(PropertyName = "age_max", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public int AgeMax { get; set; }

        [DeserializeAs(Name = "age_min")]
        [JsonProperty(PropertyName = "age_min", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public int AgeMin { get; set; }

        [DeserializeAs(Name = "geo_locations")]
        [JsonProperty(PropertyName = "geo_locations", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public GeoLocations GeoLocations { get; set; }

        [DeserializeAs(Name = "interests")]
        [JsonProperty(PropertyName = "interests", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<Interest> Interests { get; set; }

    }
}
