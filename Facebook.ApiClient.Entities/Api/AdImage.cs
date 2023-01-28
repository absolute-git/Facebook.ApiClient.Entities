using System;
using System.Collections.Generic;
using System.Linq;
using Facebook.ApiClient.Entities.Enumerations;
using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace Facebook.ApiClient.Entities.Api
{
    /// <inheritdoc />
    /// <summary>
    /// An ad object contains the data necessary to visually display an ad and associate it with a corresponding ad set.
    /// <para>https://developers.facebook.com/docs/marketing-api/reference/ad-image</para>
    /// </summary>
    public class AdImage : BaseEntity
    {
        /// <summary>
        /// The ID of the image.
        /// </summary>
        [DeserializeAs(Name = "id")]
        [JsonProperty(PropertyName = "id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Id { get; set; }

        /// <summary>
        /// The ID of the ad account that this ad belongs to.
        /// </summary>
        [DeserializeAs(Name = "account_id")]
        [JsonProperty(PropertyName = "account_id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public long? AccountId { get; set; }

        /// <summary>
        /// Created time
        /// </summary>
        [DeserializeAs(Name = "created_time")]
        [JsonProperty(PropertyName = "created_time", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// Ad creative
        /// </summary>
        [DeserializeAs(Name = "creatives")]
        [JsonProperty(PropertyName = "creatives", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<long> Creatives { get; set; }

        /// <summary>
        /// The hash which uniquely identifies the image.
        /// </summary>
        [DeserializeAs(Name = "hash")]
        [JsonProperty(PropertyName = "hash", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Hash { get; set; }

        /// <summary>
        /// The height of the image.
        /// </summary>
        [DeserializeAs(Name = "height")]
        [JsonProperty(PropertyName = "height", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public int Height { get; set; }

        /// <summary>
        /// SELF_EXPLANATORY
        /// </summary>
        [DeserializeAs(Name = "is_associated_creatives_in_adgroups")]
        [JsonProperty(PropertyName = "is_associated_creatives_in_adgroups", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public bool IsAssociatedCreativesInAdgroups { get; set; }

        /// <summary>
        /// The filename of the image. The maximum length of this string is 100 characters.
        /// </summary>
        [DeserializeAs(Name = "name")]
        [JsonProperty(PropertyName = "name", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Name { get; set; }

        /// <summary>
        /// The height of the image that was originally uploaded.
        /// </summary>
        [DeserializeAs(Name = "original_height")]
        [JsonProperty(PropertyName = "original_height", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public int OriginalHeight { get; set; }

        /// <summary>
        /// The width of the image that was originally uploaded.
        /// </summary>
        [DeserializeAs(Name = "original_width")]
        [JsonProperty(PropertyName = "original_width", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public int OriginalWidth { get; set; }

        /// <summary>
        /// A permanent URL of the image to use in story creatives.
        /// </summary>
        [DeserializeAs(Name = "permalink_url")]
        [JsonProperty(PropertyName = "permalink_url", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string PermalinkUrl { get; set; }

        /// <summary>
        /// Status of the image.
        /// </summary>
        [DeserializeAs(Name = "status")]
        [JsonProperty(PropertyName = "status", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public ImageStatus? Status { get; set; }

        /// <summary>
        /// A temporary URL which the image can be retrieved at. Do not use this URL in ad creative creation.
        /// </summary>
        [DeserializeAs(Name = "url")]
        [JsonProperty(PropertyName = "url", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Url { get; set; }

        /// <summary>
        /// A temporary URL pointing to a version of the image resized to fit within a 128x128 pixel box
        /// </summary>
        [DeserializeAs(Name = "url_128")]
        [JsonProperty(PropertyName = "url_128", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Url128 { get; set; }

        /// <summary>
        /// A temporary URL pointing to a version of the image resized to fit within a 256x256 pixel box
        /// </summary>
        [DeserializeAs(Name = "url_256")]
        [JsonProperty(PropertyName = "url_128", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Url256 { get; set; }

        /// <summary>
        /// The height of the 256 image.
        /// </summary>
        [DeserializeAs(Name = "url_256_height")]
        [JsonProperty(PropertyName = "height", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public int Url256Height { get; set; }

        /// <summary>
        /// The width of the 256 image.
        /// </summary>
        [DeserializeAs(Name = "url_256_width")]
        [JsonProperty(PropertyName = "height", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public int Url256Width { get; set; }

        /// <summary>
        /// Time the image was updated.
        /// </summary>
        [DeserializeAs(Name = "updated_time")]
        [JsonProperty(PropertyName = "updated_time", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public DateTime UpdatedTime { get; set; }

        /// <summary>
        /// The width of the image.
        /// </summary>
        [DeserializeAs(Name = "width")]
        [JsonProperty(PropertyName = "width", ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public int Width { get; set; }

        /// <summary>
        /// Get api field selectors for <see cref="Ad"/>
        /// </summary>
        /// <returns>Comma seperated fields</returns>
        public static IList<string> GetApiSelectors()
        {
            var apiFields = typeof(AdImage).GetProperties()
                .Select(e => e.GetCustomAttributes(typeof(DeserializeAsAttribute), true)).Where(e => e.Length > 0)
                .Select(e => e.First() as DeserializeAsAttribute).Where(e => e != null).Select(e => e.Name).ToList();

            return apiFields;
        }
    }
}
