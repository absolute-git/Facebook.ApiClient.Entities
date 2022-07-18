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
    /// An Ad Study enables you to analyse ads for the best strategy
    /// <para>Test your ads and choose the strategy that is driving the most conversions. For example, create a split test to find out which ad set performs the best</para>
    /// <para>https://developers.facebook.com/docs/marketing-api/reference/ad-study/</para>
    /// </summary>
    public class AdStudy : BaseEntity
    {
        /// <summary>
        /// Ad Study ID of the Lift study
        /// </summary>
        [DeserializeAs(Name = "id")]
        [JsonProperty(PropertyName = "id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public long? Id { get; set; }

        /// <summary>
        /// The business that owns this study if it exists.
        /// </summary>
        [DeserializeAs(Name = "business")]
        [JsonProperty(PropertyName = "business", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public Business Business { get; set; }

        /// <summary>
        /// Time stamp when study was canceled
        /// </summary>
        [DeserializeAs(Name = "canceled_time")]
        [JsonProperty(PropertyName = "canceled_time", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public DateTime CanceledTime { get; set; }

        /// <summary>
        /// Cooldown start time
        /// </summary>
        [DeserializeAs(Name = "cooldown_start_time")]
        [JsonProperty(PropertyName = "cooldown_start_time", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public DateTime CooldownStartTime { get; set; }

        /// <summary>
        /// Who Lift study was created by
        /// </summary>
        [DeserializeAs(Name = "created_by")]
        [JsonProperty(PropertyName = "created_by", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public User CreatedBy { get; set; }

        /// <summary>
        /// When was the Lift study created
        /// </summary>
        [DeserializeAs(Name = "created_time")]
        [JsonProperty(PropertyName = "created_time", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public DateTime CreatedTime { get; set; }


        /// <summary>
        /// Description
        /// </summary>
        [DeserializeAs(Name = "description")]
        [JsonProperty(PropertyName = "description", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Description { get; set; }

        /// <summary>
        /// End Time
        /// </summary>
        [DeserializeAs(Name = "end_time")]
        [JsonProperty(PropertyName = "end_time", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public DateTime EndTime { get; set; }

        /// <summary>
        /// Name of the Lift study
        /// </summary>
        [DeserializeAs(Name = "name")]
        [JsonProperty(PropertyName = "name", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Name { get; set; }

        /// <summary>
        /// Observation end time
        /// </summary>
        [DeserializeAs(Name = "observation_end_time")]
        [JsonProperty(PropertyName = "observation_end_time", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public DateTime ObservationEndTime { get; set; }

        /// <summary>
        /// When results for at least one objective of the study are available
        /// </summary>
        [DeserializeAs(Name = "results_first_available_date")]
        [JsonProperty(PropertyName = "results_first_available_date", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string ResultsFirstAvailableDate { get; set; }

        /// <summary>
        /// Start time
        /// </summary>
        [DeserializeAs(Name = "start_time")]
        [JsonProperty(PropertyName = "start_time", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// The type of study, either audience segmentation or lift.
        /// </summary>
        [DeserializeAs(Name = "type")]
        [JsonProperty(PropertyName = "type", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Type { get; set; }

        /// <summary>
        /// Updated by
        /// </summary>
        [DeserializeAs(Name = "updated_by")]
        [JsonProperty(PropertyName = "updated_by", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public User UpdatedBy { get; set; }

        /// <summary>
        /// Updated time
        /// </summary>
        [DeserializeAs(Name = "updated_time")]
        [JsonProperty(PropertyName = "updated_time", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public DateTime UpdatedTime { get; set; }

        /// <summary>
        /// Get api field selectors for <see cref="AdSet"/>
        /// </summary>
        /// <param name="isIncludeCampaignFields">Set true if you wan to fetch campaign details as well</param>
        /// <returns>Comma seperated fields</returns>
        public static IList<string> GetApiSelectors(bool isIncludeCampaignFields)
        {
            var apiFields = typeof(AdSet).GetProperties()
                .Select(e => e.GetCustomAttributes(typeof(DeserializeAsAttribute), true)).Where(e => e.Length > 0)
                .Select(e => e.First() as DeserializeAsAttribute).Where(e => e != null).Select(e => e.Name).ToList();


            if (!isIncludeCampaignFields) return apiFields;

            apiFields.Remove("campaign");
            apiFields.Add($"campaign.fields({string.Join(",", Campaign.GetApiSelectors())})");

            return apiFields;
        }
    }
}
