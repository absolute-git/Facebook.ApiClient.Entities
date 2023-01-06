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
    /// 
    /// </summary>
    public class OAuthResponse : BaseEntity
    {
        /// <summary>
        /// The access token
        /// </summary>
        [DeserializeAs(Name = "access_token")]
        [JsonProperty(PropertyName = "access_token", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string AccessToken { get; set; }

        /// <summary>
        /// The token type
        /// </summary>
        [DeserializeAs(Name = "token_type")]
        [JsonProperty(PropertyName = "token_type", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string TokenType { get; set; }
    }
}
