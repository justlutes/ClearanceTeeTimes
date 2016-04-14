namespace GolfNow.Mobile.Models.Enumerations
{
    /// <summary>
    /// The status of the customer's eligibility status request.
    /// </summary>
    public enum CustomerEligibilityStatus
    {
        /// <summary>
        /// The default state of the eligibility status.
        /// </summary>
        Unknown,
        
        /// <summary>
        /// The eligibility of the customer has been confirmed.
        /// </summary>
        Confirmed,
        
        /// <summary>
        /// The eligibility status of the customer is currently in progress.
        /// </summary>
        InProgress,
        
        /// <summary>
        /// The eligibility status of the customer could not be determined automatically and the customer will need to be
        /// verified manually with a call to RequestEligibilityDocumentationReview.
        /// </summary>
        RequiresManualVerification
    }
}