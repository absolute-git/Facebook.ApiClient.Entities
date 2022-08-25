using System.Collections.Generic;
using System.Linq;
using Facebook.ApiClient.Entities.Enumerations;
using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace Facebook.ApiClient.Entities.Api
{
    /// <inheritdoc />
    /// <summary>
    /// An ad creative object is an instance of a specific creative which is being used to define the <see cref="P:Facebook.ApiClient.Entities.Api.Ad.Creative" /> field of one or more <see cref="T:Facebook.ApiClient.Entities.Api.Ad" />s.
    /// <para>https://developers.facebook.com/docs/marketing-api/reference/ad-creative/</para>
    /// </summary>
    public class Creative : BaseEntity
    {
        /// <summary>
        /// The ID of this creative
        /// </summary>
        [DeserializeAs(Name = "id")]
        [JsonProperty(PropertyName = "id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public long? Id { get; set; }

        /// <summary>
        /// The ID of this creative (because the api wants a POST request with this property and GEt with above!!!!!
        /// wil need to ignore it on the fieldselector as it cant be returned
        /// </summary>
        [DeserializeAs(Name = "creative_id")]
        [JsonProperty(PropertyName = "creative_id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public long? CreativeId { get; set; }

        /// <summary>
        /// Account ID
        /// </summary>
        [DeserializeAs(Name = "account_id")]
        [JsonProperty(PropertyName = "account_id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public long? AccountId { get; set; }

        /// <summary>
        /// The actor ID (<see cref="Page.Id"/>) of this creative.
        /// </summary>
        [DeserializeAs(Name = "actor_id")]
        [JsonProperty(PropertyName = "actor_id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public long? ActorId { get; set; }

        /// <summary>
        /// <see cref="AdLabel"/>s that are associated with this creative
        /// </summary>
        [DeserializeAs(Name = "adlabels")]
        [JsonProperty(PropertyName = "adlabels", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public List<AdLabel> AdLabels { get; set; }

        /// <summary>
        /// Deep link fallback behavior for dynamic product ads if the app is not installed.
        /// </summary>
        [DeserializeAs(Name = "applink_treatment")]
        [JsonProperty(PropertyName = "applink_treatment", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public ApplinkTreatment? ApplinkTreatment { get; set; }

        /// <summary>
        /// The api spec of asset feed used for creative permutation system.
        /// </summary>
        [DeserializeAs(Name = "asset_feed_spec")]
        [JsonProperty(PropertyName = "asset_feed_spec", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string AssetFeedSpec { get; set; }

        /// <summary>
        /// Specifies whether ad was configured to be labeled as a political ad or not.\nSee [Facebook Advertising Policies](https://www.facebook.com/policies/ads). 
        /// This field cannot be used for [Dynamic Ads](https://developers.facebook.com/docs/marketing-api/dynamic-ad).
        /// </summary>
        [DeserializeAs(Name = "authorization_category")]
        [JsonProperty(PropertyName = "authorization_category", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public AuthorisationCategoryType? AuthorisationCategory { get; set; }

        /// <summary>
        /// The body of the ad
        /// </summary>
        [DeserializeAs(Name = "body")]
        [JsonProperty(PropertyName = "body", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Body { get; set; }

        /// <summary>
        /// ID for page representing business which runs Branded Content ads. 
        /// See https://developers.facebook.com/docs/marketing-api/guides/branded-content.
        /// </summary>
        [DeserializeAs(Name = "branded_content_sponsor_page_id")]
        [JsonProperty(PropertyName = "branded_content_sponsor_page_id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public long? BrandedContentSponsorPageId { get; set; }

        /// <summary>
        /// Used for CPAS local delivery image bank
        /// </summary>
        [DeserializeAs(Name = "bundle_folder_id")]
        [JsonProperty(PropertyName = "bundle_folder_id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public long? BundleFolderId { get; set; }

        /// <summary>
        /// The call to action button text and header text of legacy ads.
        /// </summary>
        [DeserializeAs(Name = "call_to_action_type")]
        [JsonProperty(PropertyName = "call_to_action_type", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public CreativeCallToActionType? CallToActionType { get; set; }

        /// <summary>
        /// The Dynamic Category Ad's categorization field, e.g. brand
        /// https://developers.facebook.com/docs/marketing-api/dynamic-ads
        /// </summary>
        [DeserializeAs(Name = "categorization_criteria")]
        [JsonProperty(PropertyName = "categorization_criteria", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public CategorisationCriteriaType? CategorisationCriteria { get; set; }

        //category_media_source
        /// <summary>
        /// The Dynamic Ad's rendering mode for category ads
        /// https://developers.facebook.com/docs/marketing-api/dynamic-ads
        /// </summary>
        [DeserializeAs(Name = "category_media_source")]
        [JsonProperty(PropertyName = "category_media_source", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public CategoryMediaSourceType? CategoryMediaSource { get; set; }

        /// <summary>
        /// Used for CPAS local delivery image bank
        /// </summary>
        [DeserializeAs(Name = "collaborative_ads_lsb_image_bank_id")]
        [JsonProperty(PropertyName = "collaborative_ads_lsb_image_bank_id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public long? CollaborativeAdsLsbImageBankId { get; set; }

        /// <summary>
        /// The ID of the Product Set for a Destination Catalog that will be used to link with Travel Catalogs
        /// </summary>
        [DeserializeAs(Name = "destination_set_id")]
        [JsonProperty(PropertyName = "destination_set_id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public long? DestinationSetId { get; set; }

        /// <summary>
        /// Used for [Store Traffic Objective inside Dynamic Ads](/docs/marketing-api/guides/dynamic-ad/store-visits). 
        /// Allows you to control the voice of your ad. If set to `DYNAMIC`, page name and profile picture in your ad post come from the nearest page location. 
        /// If set to `STORY_OWNER`, page name and profile picture in your ad post come from the main page location.
        /// </summary>
        [DeserializeAs(Name = "dynamic_ad_voice")]
        [JsonProperty(PropertyName = "dynamic_ad_voice", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string DynamicAdVoice { get; set; }

        /// <summary>
        /// Specifies whether ad was configured to be labeled as a political ad or not.\nSee [Facebook Advertising Policies](https://www.facebook.com/policies/ads). 
        /// This field cannot be used for [Dynamic Ads](https://developers.facebook.com/docs/marketing-api/dynamic-ad).
        /// </summary>
        [DeserializeAs(Name = "effective_authorization_category")]
        [JsonProperty(PropertyName = "effective_authorization_category", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public AuthorisationCategoryType? EffectiveAuthorisationCategory { get; set; }

        /// <summary>
        /// The ID of an Instagram post to use in an ad
        /// </summary>
        [DeserializeAs(Name = "effective_instagram_media_id")]
        [JsonProperty(PropertyName = "effective_instagram_media_id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public long? EffectiveInstagramMediaId { get; set; }

        /// <summary>
        /// Used for Instagram Ads. The ID of an Instagram post to display as an Instagram ad.
        /// https://developers.facebook.com/micro_site/url/?click_from_context_menu=true&country=GB&destination=https%3A%2F%2Fdevelopers.facebook.com%2Fdocs%2Fmarketing-api%2Fguides%2Finstagramads&event_type=click&last_nav_impression_id=0AMCBzVEfvecpLgrn&max_percent_page_viewed=55&max_viewport_height_px=969&max_viewport_width_px=1920&orig_http_referrer=https%3A%2F%2Fdevelopers.facebook.com%2Fdocs%2Fmarketing-api%2Freference%2Fad-creative&orig_request_uri=https%3A%2F%2Fdevelopers.facebook.com%2Fajax%2Fdocs%2Fnav%2F%3Fpath1%3Dmarketing-api%26path2%3Dreference%26path3%3Dad-creative&region=emea&scrolled=true&session_id=1hjlExylgNJ4dQW4S&site=developers
        /// </summary>
        [DeserializeAs(Name = "effective_instagram_story_id")]
        [JsonProperty(PropertyName = "effective_instagram_story_id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public long? EffectiveInstagramStoryId { get; set; }

        /// <summary>
        /// The ID of a page post to use in an ad, regardless of whether it's an organic or unpublished page post.
        /// </summary>
        [DeserializeAs(Name = "effective_object_story_id")]
        [JsonProperty(PropertyName = "effective_object_story_id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string EffectiveObjectStoryId { get; set; }

        /// <summary>
        /// Whether Direct Install should be enabled on supported devices
        /// </summary>
        [DeserializeAs(Name = "enable_direct_install")]
        [JsonProperty(PropertyName = "enable_direct_install", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public bool EnableDirectInstall { get; set; }

        /// <summary>
        /// Whether Instant App should be enabled on supported devices
        /// </summary>
        [DeserializeAs(Name = "enable_launch_instant_app")]
        [JsonProperty(PropertyName = "enable_launch_instant_app", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public bool EnableLaunchInstantApp { get; set; }

        /// <summary>
        /// A JSON object defining crop dimensions for the image specified.
        /// </summary>
        [DeserializeAs(Name = "image_crops")]
        [JsonProperty(PropertyName = "image_crops", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string ImageCrops { get; set; }

        /// <summary>
        /// Image hash for an image you can use in creatives.
        /// </summary>
        [DeserializeAs(Name = "image_hash")]
        [JsonProperty(PropertyName = "image_hash", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string ImageHash { get; set; }

        /// <summary>
        /// A URL for the image for this creative. The image specified at this URL will be saved into the ad account's image library
        /// </summary>
        [DeserializeAs(Name = "image_url")]
        [JsonProperty(PropertyName = "image_url", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// Instagram actor ID
        /// </summary>
        [DeserializeAs(Name = "instagram_actor_id")]
        [JsonProperty(PropertyName = "instagram_actor_id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public long? InstagramActorId { get; set; }

        /// <summary>
        /// Instagram permalink
        /// </summary>
        [DeserializeAs(Name = "instagram_permalink_url")]
        [JsonProperty(PropertyName = "instagram_permalink_url", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string InstagramPermalinkUrl { get; set; }

        /// <summary>
        /// The ID of an Instagram post for creating ads.
        /// </summary>
        [DeserializeAs(Name = "instagram_story_id")]
        [JsonProperty(PropertyName = "instagram_story_id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public long? InstagramStoryId { get; set; }

        /// <summary>
        /// Instagram actor ID
        /// </summary>
        [DeserializeAs(Name = "instagram_user_id")]
        [JsonProperty(PropertyName = "instagram_user_id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public long? InstagramUserId { get; set; }

        //interactive_components_spec (no spec)

        /// <summary>
        /// Overwrites the display URL for link ads when object_url is set to a click tag
        /// </summary>
        [DeserializeAs(Name = "link_destination_display_url")]
        [JsonProperty(PropertyName = "link_destination_display_url", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string LinkDestinationDisplayUrl { get; set; }

        /// <summary>
        /// The Open Graph (OG) ID for the link in this creative if the landing page has OG tags
        /// </summary>
        [DeserializeAs(Name = "link_og_id")]
        [JsonProperty(PropertyName = "link_og_id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public long? LinkOGId { get; set; }

        /// <summary>
        /// Used to identify a specific landing tab on the Page (e.g. a Page tab app) by the Page tab's URL. See connection objects for retrieving Page tabs' URLs. The likes tab is not supported.app_data parameters may be added to the url to pass data to a tab app
        /// </summary>
        [DeserializeAs(Name = "link_url")]
        [JsonProperty(PropertyName = "link_url", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string LinkUrl { get; set; }

        /// <summary>
        /// Used for Messenger sponsored message. JSON string with message for this ad creative. See Messenger Platform, Send API Reference.
        /// </summary>
        [DeserializeAs(Name = "messenger_sponsored_message")]
        [JsonProperty(PropertyName = "messenger_sponsored_message", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string MessengerSponsoredMessage { get; set; }

        /// <summary>
        /// The name of the creative in the creative library. Ad Creative names should be unique.
        /// </summary>
        [DeserializeAs(Name = "name")]
        [JsonProperty(PropertyName = "name", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Name { get; set; }

        /// <summary>
        /// The ID of the promoted_object or object that is relevant to the ad and ad type
        /// </summary>
        [DeserializeAs(Name = "object_id")]
        [JsonProperty(PropertyName = "object_id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public long? ObjectId { get; set; }

        /// <summary>
        /// iTunes or Google Play of the destination of an app ad
        /// </summary>
        [DeserializeAs(Name = "object_store_url")]
        [JsonProperty(PropertyName = "object_store_url", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string ObjectStoreUrl { get; set; }

        /// <summary>
        /// <para>The ID of a page post to use in an ad. This ID can be retrieved by using the graph API to query the posts of the page. If an image is used in the post, it will be downloaded and available in your account's image library. </para>
        /// <para>If an unpublished page post was used to create the ad, this ID will be null, but the <see cref="EffectiveObjectStoryId"/> will be the ID of the page post regardless of whether it's an organic or unpublished page post.</para>
        /// </summary>
        [DeserializeAs(Name = "object_story_id")]
        [JsonProperty(PropertyName = "object_story_id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string ObjectStoryId { get; set; }

        /// <summary>
        /// The page id and the content to create a new unpublished page post specified using one of link_data, photo_data, video_data, offer_data, text_data or template_data
        /// </summary>
        [DeserializeAs(Name = "object_story_spec")]
        [JsonProperty(PropertyName = "object_story_spec", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public ObjectStorySpec ObjectStorySpec { get; set; }

        /// <summary>
        /// The type of object that is being advertised. 
        /// </summary>
        [DeserializeAs(Name = "object_type")]
        [JsonProperty(PropertyName = "object_type", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public CreativeType? CreativeType { get; set; }

        /// <summary>
        /// Destination URL for a link ads not connected to a page
        /// </summary>
        [DeserializeAs(Name = "object_url")]
        [JsonProperty(PropertyName = "object_url", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string ObjectUrl { get; set; }

        /// <summary>
        /// The ID of the page set for this creative. See theLocal Awareness guide
        /// </summary>
        [DeserializeAs(Name = "place_page_set_id")]
        [JsonProperty(PropertyName = "place_page_set_id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public long? PlacePageSetId { get; set; }

        /// <summary>
        /// Use this field to customize the media for different Facebook placements. Currently you can use this field for customizing images only. The media specified here replaces the original media defined in the ad creative when the ad displays on those placements. For example, if you define a media here for the instagram key, Facebook uses that media instead of the media defined in the ad creative when showing the ad on Instagram.
        /// </summary>
        [DeserializeAs(Name = "platform_customizations")]
        [JsonProperty(PropertyName = "platform_customizations", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public AdCreativePlatformCustomization PlatformCustomizations { get; set; }

        /// <summary>
        /// The ID of the playable asset in this creative
        /// </summary>
        [DeserializeAs(Name = "playable_asset_id")]
        [JsonProperty(PropertyName = "playable_asset_id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public long? PlayableAssetId { get; set; }

        //portrait_customizations (no spec)

        /// <summary>
        /// The ID of the product set for this creative. See dynamic product ads for more detail
        /// </summary>
        [DeserializeAs(Name = "product_set_id")]
        [JsonProperty(PropertyName = "product_set_id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public long? ProductSetId { get; set; }

        //recommender_settings (dynamic ads)
        
        //with this field error: (#3) User must be on whitelist",
        /// <summary>
        /// The ID of Referral Ad Configuration in this creative
        /// </summary>
        //[DeserializeAs(Name = "referral_id")]
        //[JsonProperty(PropertyName = "referral_id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        //public long? ReferralId { get; set; }

        /// <summary>
        /// The ID of an Instagram post for creating ads
        /// </summary>
        [DeserializeAs(Name = "source_instagram_media_id")]
        [JsonProperty(PropertyName = "source_instagram_media_id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public long? SourceInstagramMediaId { get; set; }

        /// <summary>
        /// The status of this creative.
        /// </summary>
        [DeserializeAs(Name = "status")]
        [JsonProperty(PropertyName = "status", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public CreativeStatus? CreativeStatus { get; set; }

        /// <summary>
        /// The Tracking URL for dynamic product ads.
        /// </summary>
        [DeserializeAs(Name = "template_url")]
        [JsonProperty(PropertyName = "template_url", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string TemplateUrl { get; set; }

        /// <summary>
        /// Use this field to create url templates for dynamic product ads.
        /// </summary>
        [DeserializeAs(Name = "template_url_spec")]
        [JsonProperty(PropertyName = "template_url_spec", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public AdCreativeTemplateURLSpec TemplateUrlSpec { get; set; }

        /// <summary>
        /// thumbnail_id
        /// </summary>
        [DeserializeAs(Name = "thumbnail_id")]
        [JsonProperty(PropertyName = "thumbnail_id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public long? ThumbnailId { get; set; }

        /// <summary>
        /// The URL to a thumbnail for this creative. You can optionally request dimensions of this thumbnail by providing the thumbnail_width and thumbnail_height parameters
        /// </summary>
        [DeserializeAs(Name = "thumbnail_url")]
        [JsonProperty(PropertyName = "thumbnail_url", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string ThumbnailUrl { get; set; }

        /// <summary>
        /// Title for a link ad (not connected to a Page)
        /// </summary>
        [DeserializeAs(Name = "title")]
        [JsonProperty(PropertyName = "title", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Title { get; set; }

        /// <summary>
        /// A set of query string parameters which will replace or be appended to urls clicked from page post ads, message of the post, and canvas app install creatives only
        /// </summary>
        [DeserializeAs(Name = "url_tags")]
        [JsonProperty(PropertyName = "url_tags", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string UrlTags { get; set; }

        /// <summary>
        /// Used for App Ads. If true, we display the Facebook page associated with the app ads.
        /// </summary>
        [DeserializeAs(Name = "use_page_actor_override")]
        [JsonProperty(PropertyName = "use_page_actor_override", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public bool? UsePageActorOverride { get; set; }

        /// <summary>
        /// Facebook object ID for video in this ad creative.
        /// </summary>
        [DeserializeAs(Name = "video_id")]
        [JsonProperty(PropertyName = "video_id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public long? VideoId { get; set; }

        /// <summary>
        /// Get api field selectors for <see cref="Creative"/>
        /// </summary>
        /// <returns>Comma seperated fields</returns>
        public static IList<string> GetApiSelectors()
        {
            var prop = typeof(Creative).GetProperties()
                .Select(e => e.GetCustomAttributes(typeof(DeserializeAsAttribute), true)).Where(e => e.Length > 0)
                .Select(e => e.First() as DeserializeAsAttribute).Where(e => e != null && e.Name != "creative_id").Select(e => e.Name);     //bit hacky, but so is a different in properties between Get and POST

            return prop.ToList();
        }
    }
}
