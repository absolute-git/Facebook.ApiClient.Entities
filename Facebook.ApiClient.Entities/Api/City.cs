using Facebook.ApiClient.Entities.Enumerations;
using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace Facebook.ApiClient.Entities.Api
{
    public class City : BaseEntity
    {
        /// <summary>
        /// Key
        /// </summary>
        [DeserializeAs(Name = "key")]
        [JsonProperty(PropertyName = "key", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Key { get; set; }

        /// <summary>
        /// Radius
        /// </summary>
        [DeserializeAs(Name = "radius")]
        [JsonProperty(PropertyName = "radius", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public int Radius { get; set; }

        /// <summary>
        /// DistanceUnit
        /// </summary>
        [DeserializeAs(Name = "distance_unit")]
        [JsonProperty(PropertyName = "distance_unit", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public DistanceUnit DistanceUnit { get; set; }


    }
}