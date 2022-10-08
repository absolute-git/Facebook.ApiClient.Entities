namespace Facebook.ApiClient.Entities.Enumerations
{
    /// <summary>
    /// https://developers.facebook.com/docs/marketing-api/audiences/reference/basic-targeting#demographics
    /// Search and retrieve values for location targeting at Targeting Search API. 
    /// This targeting has two parameters: geo_locations to target locations, and optionally excluded_geo_locations to exclude areas.
    /// </summary>
    public enum LocationTargetTypes
    {
        /// <summary>
        /// country
        /// </summary>
        country,

        /// <summary>
        /// region
        /// </summary>
        region,

        /// <summary>
        /// city
        /// </summary>
        city,

        /// <summary>
        /// country_group
        /// </summary>
        country_group,

        /// <summary>
        /// geo_market
        /// </summary>
        geo_market,

        /// <summary>
        /// electoral_district (US only)
        /// </summary>
        electoral_district,

        /// <summary>
        /// zip
        /// </summary>
        zip
    }
}
