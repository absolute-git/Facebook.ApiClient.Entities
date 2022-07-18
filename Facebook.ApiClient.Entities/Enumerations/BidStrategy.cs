namespace Facebook.ApiClient.Entities.Enumerations
{
    /// <summary>
    /// Bid Strategy
    /// Choose bid strategy for this campaign to suit your specific business goals. Each strategy has tradeoffs and may be available for certain optimization_goals.
    ///Notes:
    /// If you do not enable campaign budget optimization, you should set bid_strategy at ad set level.
    /// TARGET_COST bidding strategy has been deprecated with Marketing API v9.
    /// </summary>
    public enum BidStrategy
    {
        /// <summary>
        /// Designed to get the most results for your budget based on your ad set optimization_goal without limiting your bid amount.
        /// This is the best strategy if you care most about cost efficiency.
        /// However with this strategy it may be harder to get stable average costs as you spend. This strategy is also known as automatic bidding.
        /// Learn more in Ads Help Center, About bid strategies: Lowest cost.
        /// </summary>
        LOWEST_COST_WITHOUT_CAP,

        /// <summary>
        /// Designed to get the most results for your budget based on your ad set optimization_goal while limiting actual bid to your specified amount.
        /// With a bid cap you have more control over your cost per actual optimization event. 
        /// However if you set a limit which is too low you may get less ads delivery. 
        /// If you select this, you must provide a bid cap in the bid_amount field for each ad set in this ad campaign. 
        /// Note: during creation this is the default bid strategy if you don't specify. 
        /// This strategy is also known as manual maximum-cost bidding. Learn more in Ads Help Center, About bid strategies: Lowest cost.
        /// </summary>
        LOWEST_COST_WITH_BID_CAP,

        /// <summary>
        /// COST CAP
        /// </summary>
        COST_CAP
    }
}
