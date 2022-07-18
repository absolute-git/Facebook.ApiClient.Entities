using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Facebook.ApiClient.Entities.Api
{
    /// <summary>
    /// Represents Base entity for all API entities
    /// </summary>
    public class BaseEntity
    {
        private FacebookRequestError _error;
        /// <summary>
        /// Collection of unparsed json fields from API response
        /// </summary>
        [JsonExtensionData]
#pragma warning disable 649
        private Dictionary<string, JToken> _unparsedValues;
#pragma warning restore 649

        /// <summary>
        /// Initialize new instance of BaseEntity
        /// </summary>
        internal BaseEntity()
        {
        }

        /// <summary>
        /// An error response
        /// </summary>
        public FacebookRequestError Error
        {
            get { return _error; }
            set
            {
                _error = value;
                //throw new FacebookResponseException(value.Message, value.ExceptionType, value.Code, value.SubCode, value.FbTraceId);
            }
        }

        /// <summary>
        /// Convert current entity into JSON string
        /// </summary>
        /// <returns>JSON string</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        /// <summary>
        /// Gives collection of unparsed json fields from API response
        /// </summary>
        /// <returns></returns>
        public IDictionary<string, JToken> GetUnparsedValues()
        {
            return _unparsedValues;
        }
    }
}
