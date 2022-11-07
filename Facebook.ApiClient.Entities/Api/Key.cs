using Newtonsoft.Json;
using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Facebook.ApiClient.Entities.Api
{
    public class Key
    {
        /// <summary>
        /// The unique key of the entity
        /// </summary>
        [DeserializeAs(Name = "key")]
        [JsonProperty(PropertyName = "key", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string KeyString { get; set; }
    }
}
