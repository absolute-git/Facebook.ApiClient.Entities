using Newtonsoft.Json;
using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facebook.ApiClient.Entities.Api
{
    /// <summary>
    /// https://developers.facebook.com/docs/marketing-api/error-reference
    /// </summary>
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
        /// <summary>
        /// The Facebook Error User Title
        /// </summary>
        [DeserializeAs(Name = "error_user_title")]
        [JsonProperty(PropertyName = "error_user_title", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string ErrorUserTitle { get; set; }
        /// <summary>
        /// The Facebook Error User Message
        /// </summary>
        [DeserializeAs(Name = "error_user_msg")]
        [JsonProperty(PropertyName = "error_user_msg", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string ErrorUserMsg { get; set; }

        /// <summary>
        /// The Facebook Error Data - specific field validation error info
        /// </summary>
        [DeserializeAs(Name = "error_data")]
        [JsonProperty(PropertyName = "error_data", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public dynamic ErrorData { get; set; }
    }

    /// <summary>
    /// This is a property included in the error_data blob of any API call that results in a validation error, which indicates which field(s) is at fault for the validation error. 
    /// This can be used to provide contextual errors, e.g. displaying an error right next to the field(s) at fault in the GUI of an ad creation tool.
    /// </summary>
    public class ErrorData
    {
        /// <summary>
        /// blame_field_specs is an array, where each element of the array is a blame_field_spec which indicates a single field from the API spec that is at fault.
        /// A blame_field_spec itself is an array also, which indicates the name of the field that is at fault and the location of this field within the overall API spec provided.
        /// </summary>
        [DeserializeAs(Name = "blame_field_specs ")]
        [JsonProperty(PropertyName = "blame_field_specs ", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<dynamic> BlameFields { get; set; }
    }


}
