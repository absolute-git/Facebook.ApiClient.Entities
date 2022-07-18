using Newtonsoft.Json;
using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facebook.ApiClient.Entities.Api
{
    public class FacebookRequestError
    {
        /// <summary>
        /// The Error message
        /// </summary>
        [DeserializeAs(Name = "message")]
        [JsonProperty(PropertyName = "message", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Message { get; set; }
        /// <summary>
        /// The error type
        /// </summary>
        [DeserializeAs(Name = "type")]
        [JsonProperty(PropertyName = "type", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string ExceptionType { get; set; }
        /// <summary>
        /// The Error Code
        /// </summary>
        [DeserializeAs(Name = "code")]
        [JsonProperty(PropertyName = "code", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public int Code { get; set; }
        /// <summary>
        /// The Error Sub Code
        /// </summary>
        [DeserializeAs(Name = "error_subcode")]
        [JsonProperty(PropertyName = "error_subcode", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public int SubCode { get; set; }
        /// <summary>
        /// The Facebook Error Trace ID
        /// </summary>
        [DeserializeAs(Name = "fbtrace_id")]
        [JsonProperty(PropertyName = "fbtrace_id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string FbTraceId { get; set; }

    }
}
