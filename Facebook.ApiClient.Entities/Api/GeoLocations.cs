using System.Collections.Generic;
using Facebook.ApiClient.Entities.Enumerations;
using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace Facebook.ApiClient.Entities.Api
{
    /// <inheritdoc />
    /// <summary>
    /// Search and retrieve values for location targeting at Targeting Search API. This targeting has two parameters:
    /// geo_locations to target locations, and optionally excluded_geo_locations to exclude areas
    /// Use country_groups for geo_locations to target broader geographic regions such as Europe or North America.
    /// <para>https://developers.facebook.com/docs/marketing-api/audiences/reference/basic-targeting</para>
    /// </summary>
    public class GeoLocations : BaseEntity
    {
        /// <summary>
        /// The source url of the app links object
        /// </summary>
        [DeserializeAs(Name = "countries")]
        [JsonProperty(PropertyName = "countries", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<string> Countries { get; set; }

        /// <summary>
        /// State, province, or region. Available values, see Targeting Search, Regions. Limit: 200.
        /// Example: 'regions': [{'key':'3847'}]
        /// </summary>
        [DeserializeAs(Name = "regions")]
        [JsonProperty(PropertyName = "regions", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public Dictionary<string, string> Regions { get; set; }

        /// <summary>
        /// Specify key, radius & distance_unit. For key, see Targeting Search, Cities. radius is a distance around cities, from 10 to 50 miles or 17 to 80 kilometers. distance_unit is mile or kilometer. Limit: 250.
        /// Example: 'cities': [{'key':'2430536', 'radius':12, 'distance_unit':'mile'}]
        /// </summary>
        [DeserializeAs(Name = "cities")]
        [JsonProperty(PropertyName = "cities", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<City> Cities { get; set; }

        /// <summary>
        /// Target Zip Code, See targeting search API. Limit: 50,000. Formerly 2,500. If you provide more than 2,500 we create an array known as location_cluster which represents a set of zip codes. 
        /// Example: 'zips':[{'key':'US:94304'},{'key':'US:00501'}]
        /// To read a location_cluster and see the locations targeted: GET /location_cluster_ID
        /// To edit a location_cluster, specify locations: POST /location_cluster_ID
        /// </summary>
        [DeserializeAs(Name = "zips")]
        [JsonProperty(PropertyName = "zips", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public Dictionary<string, string> Zips { get; set; }

        /// <summary>
        /// Target Zip Code, See targeting search API. Limit: 50,000. Formerly 2,500. If you provide more than 2,500 we create an array known as location_cluster which represents a set of zip codes. 
        /// Example: 'zips':[{'key':'US:94304'},{'key':'US:00501'}]
        /// To read a location_cluster and see the locations targeted: GET /location_cluster_ID
        /// To edit a location_cluster, specify locations: POST /location_cluster_ID
        /// </summary>
        [DeserializeAs(Name = "places")]
        [JsonProperty(PropertyName = "places", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<Place> Places { get; set; }

        /// <summary>
        /// recent: People whose recent location is selected area, as determined from mobile device data. Not available to exclud locations.
        /// home: People whose stated location in Facebook profile “current city” is in an area.
        /// Facebook validates this by IP and information from their friends’ profile locations.
        /// travel_in: People whose most recent location is selected area. 
        /// Determined by mobile device data, and more than 100 miles from stated current city in their Facebook profile.Not available to exclude locations.
        /// Please Note:
        /// If no location_types, defaults to ['home'].
        /// You cannot use travel_in with other values in location_types.
        /// To target “people living in or recently in this location”, add both recent and home in location_types.
        /// Examples: 'location_types':['recent', 'home'] 'location_types':['travel_in']
        /// </summary>
        [DeserializeAs(Name = "location_types")]
        [JsonProperty(PropertyName = "location_types", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<LocationType> LocationTypes { get; set; }

    }
}
