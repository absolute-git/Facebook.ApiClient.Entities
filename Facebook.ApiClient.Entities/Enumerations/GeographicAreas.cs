namespace Facebook.ApiClient.Entities.Enumerations
{
    /// <summary>
    /// GeographicAreas
    /// We have other geographical areas you can use to target. Some of these areas are not yet defined, as noted below.
    /// </summary>
    public enum GeographicAreas
    {
        /// <summary>
        /// Known commonly as a district or governate covering hundreds of square kilometers or more. Example: Akkar in Lebanon.
        /// </summary>
        large_geo_area,

        /// <summary>
        /// Known commonly as a county, covering more than one city. Example: Henrico county in the state of Virginia in United States
        /// </summary>
        medium_geo_area,

        /// <summary>
        /// Known commonly as a residential area near a city or town. Example: El Rosario near Marbella in Spain.
        /// </summary>
        small_geo_area,

        /// <summary>
        /// Such as a borough. Example: Brooklyn in New York.
        /// </summary>
        subcity,

        /// <summary>
        /// Area within a city. Example: Barton Estates, Irving in Texas.
        /// </summary>
        neighborhood,

        /// <summary>
        /// Not yet available. (v14.0)
        /// </summary>
        subneighborhood,

        /// <summary>
        /// Densely populated area surround a larger city. Not yet available.
        /// </summary>
        metro_area
    }
}
