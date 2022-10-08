using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace Facebook.ApiClient.Entities.Api
{
    /// <inheritdoc />
    /// <summary>
    /// Cursors for Cursor-based Pagination
    /// Cursor-based pagination is the most efficient method of paging and should always be used when possible. 
    /// A cursor refers to a random string of characters which marks a specific item in a list of data. 
    /// The cursor will always point to the item, however it will be invalidated if the item is deleted or removed. 
    /// Therefore, your app shouldn't store cursors or assume that they will be valid in the future.
    /// <para>https://developers.facebook.com/docs/graph-api/results</para>
    /// </summary>
    public class Cursors : BaseEntity
    {
        /// <summary>
        /// This is the cursor that points to the end of the page of data that has been returned.
        /// </summary>
        [DeserializeAs(Name = "after")]
        [JsonProperty(PropertyName = "after", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string After { get; set; }

        /// <summary>
        /// This is the cursor that points to the start of the page of data that has been returned.
        /// </summary>
        [DeserializeAs(Name = "before")]
        [JsonProperty(PropertyName = "before", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Before { get; set; }

    }
}
