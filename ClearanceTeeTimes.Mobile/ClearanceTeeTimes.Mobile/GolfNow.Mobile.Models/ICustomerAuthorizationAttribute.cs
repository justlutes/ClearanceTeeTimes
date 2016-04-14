namespace GolfNow.Mobile.Models
{
    public interface ICustomerAuthorizationAttribute
    {
        /// <summary>
        /// Gets the case insensitive name of the input parameter used by the method to designate the customer's id (default: CustomerEmail).
        /// </summary>  
        string CustomerResourceIDParameter
        {
            get;
        }

        /// <summary>
        /// Gets a value indicating whether customer authentication credentials will be validated against the CustomerEmail parameter (defaults to false).
        /// </summary>
        bool IsCustomerAuthorizationRequired
        {
            get;
        }
    }
}
