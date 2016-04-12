namespace GolfNow.Mobile.Models.DataContracts
{
    /// <summary>
    /// An item that can be used to search for details about an area.
    /// </summary>
    public class AreaSearchItem
    {
        /// <summary>
        /// The identifier of the area.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int AreaID { get; set; }

        /// <summary>
        /// The text associated with the area.
        /// </summary>
        /// <value>
        /// The text.
        /// </value>
        public string Text { get; set; }
    }
}