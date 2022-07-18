using Facebook.ApiClient.Entities.Api;

namespace Facebook.ApiClient.Entities.Enumerations
{

    /// <summary>
    /// Which optimization goal this ad set is using
    /// </summary>
    public enum OptimizationSubEvent
    {
        /// <summary>
        /// Only available in read mode for campaigns created pre v2.4
        /// </summary>
        NONE,

        /// <summary>
        /// Optimize for people more likely to install your app.
        /// </summary>
        VIDEO_SOUND_ON,

        /// <summary>
        /// Optimize to reach the most number of users who are likely to spend at least a minimum amount of time on the image or video
        /// </summary>
        TRIP_CONSIDERATION,

        /// <summary>
        ///  Optimize for people more likely to click anywhere in the ad.
        /// </summary>
        TRAVEL_INTENT,

        /// <summary>
        /// Optimize for people more likely to take a particular action in your app 
        /// </summary>
        TRAVEL_INTENT_NO_DESTINATION_INTENT,

        /// <summary>
        /// FBX only 
        /// </summary>
        TRAVEL_INTENT_BUCKET_01,

        /// <summary>
        /// Optimize for people more likely to attend your event 
        /// </summary>
        TRAVEL_INTENT_BUCKET_02,

        /// <summary>
        ///  Show the ads as many times as possible 
        /// </summary>
        TRAVEL_INTENT_BUCKET_03,

        /// <summary>
        /// Optimize for people more likely to fill out a lead generation form.
        /// </summary>
        TRAVEL_INTENT_BUCKET_04,

        /// <summary>
        /// Optimize for people more likely to click in the link of the ad. 
        /// </summary>
        TRAVEL_INTENT_BUCKET_05
    }
}
