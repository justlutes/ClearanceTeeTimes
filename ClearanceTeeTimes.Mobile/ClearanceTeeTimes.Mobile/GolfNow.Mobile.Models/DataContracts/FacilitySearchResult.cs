namespace GolfNow.Mobile.Models.DataContracts
{
    /// <summary>
    /// The result of a search for facilities.
    /// </summary>
    public class FacilitySearchResult
    {
        /// <summary>
        /// Gets or sets the items.
        /// </summary>
        /// <value>
        /// The items.
        /// </value>
        public FacilitySearchItem[] Items { get; set; }

        /// <summary>
        /// Gets or sets the total results found in the search.
        /// </summary>
        /// <value>
        /// The total results.
        /// </value>
        public int TotalResults { get; set; }
    }
}