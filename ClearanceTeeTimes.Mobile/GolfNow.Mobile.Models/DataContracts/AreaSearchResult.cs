namespace GolfNow.Mobile.Models.DataContracts
{
    /// <summary>
    /// Results of a federated search for areas.
    /// </summary>
    public class AreaSearchResult
    {
        /// <summary>
        /// Gets or sets the items returned from the federated search.
        /// </summary>
        /// <value>
        /// The items.
        /// </value>
        public AreaSearchItem[] Items { get; set; }
        
        /// <summary>
        /// Gets or sets the total number of items found in the search regardless of how many were returned.
        /// </summary>
        /// <value>
        /// The total results.
        /// </value>
        public int TotalResults { get; set; }
    }
}