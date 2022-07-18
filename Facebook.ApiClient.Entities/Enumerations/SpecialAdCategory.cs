namespace Facebook.ApiClient.Entities.Enumerations
{
    /// <summary>
    /// All businesses using the Marketing API must identify whether or not new and edited campaigns belong to a Special Ad Category. 
    /// Current available categories are: housing, employment, credit, or issues, elections, and politics. 
    /// Businesses whose ads do not belong to a Special Ad Category must indicate NONE or send an empty array in the special_ad_categories field.
    /// </summary>
    public enum SpecialAdCategory
    {
        /// <summary>
        /// NONE
        /// </summary>
        NONE,
        /// <summary>
        /// EMPLOYMENT
        /// </summary>
        EMPLOYMENT,
        /// <summary>
        /// HOUSING
        /// </summary>
        HOUSING,
        /// <summary>
        /// CREDIT
        /// </summary>
        CREDIT,
        /// <summary>
        /// ISSUES_ELECTIONS_POLITICS
        /// </summary>
        ISSUES_ELECTIONS_POLITICS,
        /// <summary>
        /// ONLINE_GAMBLING_AND_GAMING
        /// </summary>
        ONLINE_GAMBLING_AND_GAMING
    }
}

