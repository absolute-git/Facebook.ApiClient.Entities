namespace Facebook.ApiClient.Entities.Enumerations
{
    /// <summary>
    /// A string indicating the object type of this post.
    /// </summary>
    public enum TargetingOptionStatus
    {
        /// <summary>
        /// NORMAL
        /// </summary>
        NORMAL,

        /// <summary>
        /// Does not deliver, though the ad set may continue to deliver according to predetermined rules.
        /// </summary>
        NONDELIVERABLE,

        /// <summary>
        /// Ad sets targeted at this objective continue to deliver, but the object can't be used to create new or update ad sets. 
        /// When updated, ad sets with with this term will be rejected, unless the term is removed.
        /// </summary>
        DEPRECATING,

        /// <summary>
        /// The object can't be used in targeting exclusions.
        /// </summary>
        INCLUSIONONLY,

        /// <summary>
        /// UNKNOWN
        /// </summary>
        UNKNOWN
    }
}
