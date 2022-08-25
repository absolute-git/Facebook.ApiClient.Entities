namespace Facebook.ApiClient.Entities.Enumerations
{

    /// <summary>
    /// Specifies how to render the category carousel card.
    /// </summary>
    public enum CategoryMediaSourceType
    {
        /// <summary>
        /// (default) Uses the category's image if exists; otherwise, falls back to products_collage.
        /// </summary>
        mixed,

        /// <summary>
        /// Uses the category's image. Skip this category if this category doesn't have a image.
        /// </summary>
        category,

        /// <summary>
        /// Generates a 2x2 collage of product images from this category.
        /// </summary>
        products_collage,

        /// <summary>
        /// Renders a slideshow of products from this category.
        /// </summary>
        products_slideshow
    }
}
