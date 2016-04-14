namespace GolfNow.Mobile.Models.DataContracts
{
    /// <summary>
    /// An item that can be used to search for details about a facility.
    /// </summary>
    public class FacilitySearchItem
    {
        /// <summary>
        /// The facility identifier.
        /// </summary>
        /// <value>
        /// The facility identifier.
        /// </value>
        public int FacilityID { get; set; }

        /// <summary>
        /// The text associated with the facility.
        /// </summary>
        /// <value>
        /// The text.
        /// </value>
        public string Text { get; set; }
    }
}