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
    /// Ad Campaign
    /// <para>https://developers.facebook.com/docs/marketing-api/reference/ad-campaign-group</para>
    /// </summary>
    public class Campaign : BaseEntity
    {
        //v14.0 missing fields: budget_rebalance_flag (U), budget_remaining, can_create_brand_lift_study, can_use_spend_cap, daily_budget (C, U), is_skadnetwork_attribution (C, U), issues_info#
        /// last_budget_toggling_time, lifetime_budget, pacing_type, promoted_object (C, U), smart_promotion_type (U), source_campaign, source_campaign_id (C), topline_id (C), special_ad_category_country (C, U)
        /// execution_options (C, U), campaign_optimization_type (C, U), is_using_l3_schedule (C, U), iterative_split_test_configs (C, U), lifetime_budget (C, U), upstream_events (C, U)
        /// adset_bid_amounts (U), adset_budgets (U)
        /// <summary>
        /// Campaign's ID
        /// </summary>
        [DeserializeAs(Name = "id")]
        [JsonProperty(PropertyName = "id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public long? Id { get; set; }

        /// <summary>
        /// ID of the ad account that owns this campaign
        /// </summary>
        [DeserializeAs(Name = "account_id")]
        [JsonProperty(PropertyName = "account_id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public long? AccountId { get; set; }

        /// <summary>
        /// Ad Labels associated with this campaign (C, U)
        /// </summary>
        [DeserializeAs(Name = "adlabels")]
        [JsonProperty(PropertyName = "adlabels", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<AdLabel> AdLabels { get; set; }

        /// <summary>
        /// Bid Strategy (C, U)
        /// </summary>
        [DeserializeAs(Name = "bid_strategy")]
        [JsonProperty(PropertyName = "bid_strategy", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public BidStrategy? BidStrategy { get; set; }

        /// <summary>
        /// Boosted Object Id
        /// </summary>
        [DeserializeAs(Name = "boosted_object_id")]
        [JsonProperty(PropertyName = "boosted_object_id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public int? BoostedObjectId { get; set; }

        /// <summary>
        /// Buying type (C)
        /// </summary>
        [DeserializeAs(Name = "brand_lift_studies")]
        [JsonProperty(PropertyName = "brand_lift_studies", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<AdStudy> BrandLiftStudies { get; set; }

        /// <summary>
        /// Buying type
        /// </summary>
        [DeserializeAs(Name = "buying_type")]
        [JsonProperty(PropertyName = "buying_type", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public BuyingType? BuyingType { get; set; }

        /// <summary>
        /// Whether the campaign can set the spend cap
        /// </summary>
        [DeserializeAs(Name = "can_use_spend_cap")]
        [JsonProperty(PropertyName = "can_use_spend_cap", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public bool? CanUseSpendCap { get; set; }

        /// <summary>
        /// Campaign configured status
        /// </summary>
        [DeserializeAs(Name = "configured_status")]
        [JsonProperty(PropertyName = "configured_status", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public CampaignConfiguredStatus? ConfiguredStatus { get; set; }

        /// <summary>
        /// Created Time
        /// </summary>
        [DeserializeAs(Name = "created_time")]
        [JsonProperty(PropertyName = "created_time", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// The effective status of this campaign.
        /// </summary>
        [DeserializeAs(Name = "effective_status")]
        [JsonProperty(PropertyName = "effective_status", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public CampaignEffectiveStatus? EffectiveStatus { get; set; }

        /// <summary>
        /// Campaign's name (C, U)
        /// </summary>
        [DeserializeAs(Name = "name")]
        [JsonProperty(PropertyName = "name", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Name { get; set; }

        /// <summary>
        /// Campaign's objective (C, U)
        /// </summary>
        [DeserializeAs(Name = "objective")]
        [JsonProperty(PropertyName = "objective", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public CampaignObjective? Objective { get; set; }

        /// <summary>
        /// If there are recommendations for this campaign, this field includes them. 
        /// </summary>
        [DeserializeAs(Name = "recommendations")]
        [JsonProperty(PropertyName = "recommendations", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<AdRecommendation> Recommendations { get; set; }

        /// <summary>
        /// special ad categories (C, U)
        /// </summary>
        [DeserializeAs(Name = "special_ad_categories")]
        [JsonProperty(PropertyName = "special_ad_categories", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Include, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<SpecialAdCategory> SpecialAdCategories { get; set; }

        /// <summary>
        /// The campaign's Special Ad Category. One of HOUSING, EMPLOYMENT, CREDIT, or NONE. (U)
        /// </summary>
        [DeserializeAs(Name = "special_ad_category")]
        [JsonProperty(PropertyName = "special_ad_category", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public SpecialAdCategory SpecialAdCategory { get; set; }

        /// <summary>
        /// A spend cap for the campaign (C, U)
        /// </summary>
        [DeserializeAs(Name = "spend_cap")]
        [JsonProperty(PropertyName = "spend_cap", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public int? SpendCap { get; set; }

        /// <summary>
        /// Start Time (C, U)
        /// </summary>
        [DeserializeAs(Name = "start_time")]
        [JsonProperty(PropertyName = "start_time", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Campaign status (C, U)
        /// </summary>
        [DeserializeAs(Name = "status")]
        [JsonProperty(PropertyName = "status", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public CampaignStatus? Status { get; set; }

        /// <summary>
        /// Stop Time (C, U)
        /// </summary>
        [DeserializeAs(Name = "stop_time")]
        [JsonProperty(PropertyName = "stop_time", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string StopTime { get; set; }

        /// <summary>
        /// Updated Time
        /// </summary>
        [DeserializeAs(Name = "updated_time")]
        [JsonProperty(PropertyName = "updated_time", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string UpdatedTime { get; set; }

        /// <summary>
        /// Get api field selectors for <see cref="Campaign"/>
        /// </summary>
        /// <returns>Comma seperated fields</returns>
        public static IList<string> GetApiSelectors()
        {
            var apiFields = typeof(Campaign).GetProperties()
                .Select(e => e.GetCustomAttributes(typeof(DeserializeAsAttribute), true)).Where(e => e.Length > 0)
                .Select(e => e.First() as DeserializeAsAttribute).Where(e => e != null).Select(e => e.Name);

            return apiFields.ToList();
        }

    }
}
