using System;
using Facebook.ApiClient.Entities.Enumerations;
using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace Facebook.ApiClient.Entities.Api
{
    /// <inheritdoc />
    /// <summary>
    /// The entity for results pagination. Most responses are paginated by default
    /// Cursor-based, Time-based or Offset-based
    /// <para>https://developers.facebook.com/docs/graph-api/results</para>
    /// </summary>
    public class Paging : BaseEntity
    {
        /// <summary>
        /// Cursor-based pagination entity
        /// </summary>
        [DeserializeAs(Name = "cursors")]
        [JsonProperty(PropertyName = "cursors", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public Cursors PageCursors { get; set; }

        /// <summary>
        /// The Graph API endpoint that will return the previous page of data. If not included, this is the first page of data.
        /// </summary>
        [DeserializeAs(Name = "previous")]
        [JsonProperty(PropertyName = "previous", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Previous { get; set; }

        /// <summary>
        /// The Graph API endpoint that will return the next page of data. 
        /// If not included, this is the last page of data. Due to how pagination works with visibility and privacy, it is possible that a page may be empty but contain a next paging link. 
        /// Stop paging when the next link no longer appears.
        /// </summary>
        [DeserializeAs(Name = "next")]
        [JsonProperty(PropertyName = "next", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Next { get; set; }

    }
}
