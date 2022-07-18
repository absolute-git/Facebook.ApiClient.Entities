using Newtonsoft.Json;
using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facebook.ApiClient.Entities.Api
{
    public class FacebookResponseException : Exception
    {
        /// <summary>
        /// The Error message
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// The error type
        /// </summary>
        public string ExceptionType { get; set; }
        /// <summary>
        /// The Error Code
        /// </summary>
        public int ErrorCode { get; set; }
        /// <summary>
        /// The Error Sub Code
        /// </summary>
        public int ErrorSubcode { get; set; }
        /// <summary>
        /// The Facebook Error Trace ID
        /// </summary>
        public string FbTraceId { get; set; }

        //
        // Summary:
        //     Initializes a new instance of the Facebook.FacebookApiException class.
        //
        // Parameters:
        //   message:
        //     The message.
        //
        //   errorType:
        //     Type of the error.
        //
        //   errorCode:
        //     Code of the error.
        public FacebookResponseException(string message, string errorType, int errorCode, int errorSubcode, string fbTraceId)
        {
            ErrorSubcode = errorSubcode;
            ExceptionType = errorType;
            ErrorCode = errorCode;
            Message = message;
            FbTraceId = fbTraceId;
        }


    }
}
