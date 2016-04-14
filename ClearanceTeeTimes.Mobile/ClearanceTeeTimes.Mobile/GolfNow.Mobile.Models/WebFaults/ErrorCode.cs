using System.Net;

namespace GolfNow.Mobile.Models.WebFaults
{
    /// <summary>
    /// A list of error codes.
    /// </summary>
    public enum ErrorCode : long
    {
        [ErrorCode("Undocumented Internal Server Error", HttpStatusCode.InternalServerError)]
        InternalServerError = 0,

        [ErrorCode("Unable to parse lookup value.", HttpStatusCode.BadRequest)]
        UnableToParseEnum = 2,

        [ErrorCode("Client username not specified.", HttpStatusCode.Forbidden)]
        ClientUserNameNotSpecified = 3,

        [ErrorCode("Client secret not specified.", HttpStatusCode.Forbidden)]
        ClientSecretNotSpecified = 4,

        [ErrorCode("Client timestamp is required with authorization.", HttpStatusCode.Forbidden)]
        ClientTimestampRequired = 5,

        [ErrorCode("Invalid client timestamp.", HttpStatusCode.Forbidden)]
        InvalidClientTimestamp = 6,

        [ErrorCode("Client timestamp Expired.", HttpStatusCode.Forbidden)]
        ClientTimestampExpired = 7,

        [ErrorCode("Cleint username or authorization do not match.", HttpStatusCode.Forbidden)]
        ClientUserNameDoesNotMatch = 8,

        [ErrorCode("Client username or password do not match.", HttpStatusCode.Forbidden)]
        ClientUsernamePasswordMismatch = 9,

        [ErrorCode("Customer Email Not Specified.", HttpStatusCode.Ambiguous)]
        CustomerEmailNotSpecified = 10,

        [ErrorCode("CustomerToken value not found in header.", HttpStatusCode.Forbidden)]
        NoCustomerToken = 11,

        [ErrorCode("The CustomerToken is invalid.", HttpStatusCode.Forbidden)]
        InvalidCustomerToken = 12,

        [ErrorCode("Customer not found.", HttpStatusCode.NotFound)]
        CustomerNotFound = 13,

        [ErrorCode("Customer token does not match client.", HttpStatusCode.Forbidden)]
        ClientCustomerTokenMismatch = 14,

        [ErrorCode("Invalid customer or token.", HttpStatusCode.Forbidden)]
        InvalidCustomerOrToken = 15,

        [ErrorCode("A buddy is required.", HttpStatusCode.BadRequest)]
        BuddyRequired = 16,

        [ErrorCode("Buddy email address required.", HttpStatusCode.BadRequest)]
        BuddyEmailRequired = 17,

        [ErrorCode("Buddy email address is not valid.", HttpStatusCode.BadRequest)]
        BuddyEmailInvalid = 18,

        [ErrorCode("Customer token expired.", HttpStatusCode.Forbidden)]
        CustomerTokenExpired = 19,

        [ErrorCode("Invalid input detected.", HttpStatusCode.BadRequest)]
        InvalidInput = 20,

        [ErrorCode("Resource Not Found", HttpStatusCode.NotFound)]
        NotFound = 21,

        [ErrorCode("Access Denied", HttpStatusCode.Forbidden)]
        AccessDenied = 22,

        [ErrorCode("Bad Request", HttpStatusCode.BadRequest)]
        BadRequest = 23,

        [ErrorCode("Gone", HttpStatusCode.Gone)]
        Gone = 24,

        [ErrorCode("Buddy email address is required in the body.", HttpStatusCode.BadRequest)]
        BuddyEmailRequiredInBody = 25,

        [ErrorCode("Golf buddy was not found.", HttpStatusCode.NotFound)]
        BuddyNotFound = 26,

        [ErrorCode("Invalid channel id.", HttpStatusCode.BadRequest)]
        InvalidChannelID = 27,

        [ErrorCode("Invalid country code.", HttpStatusCode.BadRequest)]
        InvalidCountryCode = 28,

        [ErrorCode("Channel id is required.", HttpStatusCode.BadRequest)]
        ChannelIdRequired = 29,

        [ErrorCode("Invalid player count.", HttpStatusCode.BadRequest)]
        InvalidPlayerCount = 30,

        [ErrorCode("Invalid hole count.", HttpStatusCode.BadRequest)]
        InvalidHoleCount = 31,

        [ErrorCode("Invalid take parameter.", HttpStatusCode.BadRequest)]
        InvalidTakeParameter = 32,

        [ErrorCode("Invalid skip parameter.", HttpStatusCode.BadRequest)]
        InvalidSkipParameter = 33,

        [ErrorCode("Cannot parse sort direction.", HttpStatusCode.BadRequest)]
        UnableToParseSortDirection = 34,

        [ErrorCode("Invalid state province code.", HttpStatusCode.BadRequest)]
        InvalidStateCode = 35,

        [ErrorCode("Invalid facility id.", HttpStatusCode.BadRequest)]
        InvalidFacilityId = 36,

        [ErrorCode("Invalid tee time rate id.", HttpStatusCode.BadRequest)]
        InvalidTeeTimeRateId = 37,

        [ErrorCode("Invalid start date.", HttpStatusCode.BadRequest)]
        InvalidStartDate = 38,

        [ErrorCode("Invalid end date.", HttpStatusCode.BadRequest)]
        InvalidEndDate = 39,

        [ErrorCode("Invalid city.", HttpStatusCode.BadRequest)]
        InvalidCity = 40,

        [ErrorCode("Facility not found.", HttpStatusCode.NotFound)]
        FacilityNotFound = 41,

        [ErrorCode("Invalid customer profile", HttpStatusCode.BadRequest)]
        InvalidCustomerProfile = 42,

        [ErrorCode("Resident facility already exists.", HttpStatusCode.Conflict)]
        ResidentFacilityAlreadyExists = 43,

        [ErrorCode("Favorite facility does not exist.", HttpStatusCode.NotFound)]
        FavoriteFacilityDoesNotExist = 44,

        [ErrorCode("Resident facility does not exist.", HttpStatusCode.NotFound)]
        ResidentFacilityDoesNotExist = 45,

        [ErrorCode("Invalid reservation Id.", HttpStatusCode.BadRequest)]
        InvalidReservationId = 46,

        [ErrorCode("Reservation does not exist.", HttpStatusCode.NotFound)]
        ReservationDoesNotExist = 47,

        [ErrorCode("Sort not implemented.", HttpStatusCode.BadRequest)]
        SortNotImplemented = 48,

        [ErrorCode("Customer token required.", HttpStatusCode.BadRequest)]
        CustomerTokenRequired = 49,

        [ErrorCode("Invalid timeout specified.", HttpStatusCode.BadRequest)]
        InvalidTimeoutSpecified = 50,

        [ErrorCode("Authentication failed.", HttpStatusCode.Forbidden)]
        AuthenticationFailed = 51,

        [ErrorCode("Invalid market id.", HttpStatusCode.BadRequest)]
        InvalidMarketId = 52,

        [ErrorCode("Market not found.", HttpStatusCode.NotFound)]
        MarketNotFound = 53,

        [ErrorCode("Postal code required", HttpStatusCode.BadRequest)]
        PostalCodeRequired = 54,

        [ErrorCode("Unable to parse date", HttpStatusCode.BadRequest)]
        UnableToParseDate = 55,

        [ErrorCode("Unable to parse decimal", HttpStatusCode.BadRequest)]
        UnableToParseDecimal = 56,

        [ErrorCode("Unable to parse time.", HttpStatusCode.BadRequest)]
        UnableToParseTime = 57,

        [ErrorCode("Parameter query is required.", HttpStatusCode.BadRequest)]
        ParameterQueryRequired = 58,

        [ErrorCode("Invalid subscription list id.", HttpStatusCode.BadRequest)]
        InvalidSubscriptionListId = 59,

        [ErrorCode("Invalid subscription status.", HttpStatusCode.BadRequest)]
        InvalidSubscriptionStatus = 60,

        [ErrorCode("The to-email address is required.", HttpStatusCode.BadRequest)]
        ToEmailAddressRequired = 61,

        [ErrorCode("Invalid agreement statement id.", HttpStatusCode.BadRequest)]
        InvalidAgreementStatementId = 62,

        [ErrorCode("Agreement statement was not found.", HttpStatusCode.NotFound)]
        AgreementStatementNotFound = 63,

        [ErrorCode("Proximity too small.", HttpStatusCode.BadRequest)]
        ProximityTooSmall = 64,

        [ErrorCode("Unable to parse redirect parameter.", HttpStatusCode.BadRequest)]
        UnableToParseRedirectParameter = 65,

        [ErrorCode("Current password not specified.", HttpStatusCode.BadRequest)]
        CurrentPasswordNotSpecified = 66,

        [ErrorCode("New password not specified.", HttpStatusCode.BadRequest)]
        NewPasswordNotSpecified = 67,

        [ErrorCode("An object was not specified in the request.", HttpStatusCode.BadRequest)]
        ObjectNotSpecified = 68,

        [ErrorCode("A customer username was not specified.", HttpStatusCode.BadRequest)]
        CustomerUsernameNotSpecified = 69,

        [ErrorCode("Customer guid not specified.", HttpStatusCode.BadRequest)]
        CustomerGuidNotSpecified = 70,

        [ErrorCode("Tagcode not specified.", HttpStatusCode.BadRequest)]
        TagCodeNotSpecified = 71,

        [ErrorCode("Channel settings not found.", HttpStatusCode.NotFound)]
        ChannelSettingsNotFound = 72,

        [ErrorCode("The fogot password url was not specified.", HttpStatusCode.BadRequest)]
        ForgotPasswordUrlNotSpecified = 73,

        [ErrorCode("The reset password url was not specified.", HttpStatusCode.BadRequest)]
        ResetPasswordUrlNotSpecified = 74,

        [ErrorCode("The login url was not specified.", HttpStatusCode.BadRequest)]
        LoginUrlNotSpecified = 75,

        [ErrorCode("Property emailbodytext exceeds the maximum character limit of 255 characters.", HttpStatusCode.BadRequest)]
        EmailBodyTextInvalid = 76,

        [ErrorCode("The request contained an invalid character for one or more literal values.", HttpStatusCode.BadRequest)]
        InvalidCharacter = 77,

        [ErrorCode("An invalid parameter was passed.", HttpStatusCode.BadRequest)]
        InvalidParameter = 78,

        [ErrorCode("This operation is not allowed for the specified channel.", HttpStatusCode.Forbidden)]
        OperationNotAllowedForChannel = 79,

        [ErrorCode("Invalid purchase reference ID specified.", HttpStatusCode.BadRequest)]
        InvalidPurchaseReferenceId = 80,

        [ErrorCode("Invalid purchase object specified.", HttpStatusCode.BadRequest)]
        InvalidPurchaseObject = 81,

        [ErrorCode("Invalid purchase data specified.", HttpStatusCode.BadRequest)]
        InvalidPurchaseDateSpecified = 82,

        [ErrorCode("Invalid purchase information specified.", HttpStatusCode.BadRequest)]
        InvalidPurchaseInformationSpecified = 83,

        [ErrorCode("Purchase already exists.", HttpStatusCode.Conflict)]
        PurchaseAlreadyExists = 84,

        [ErrorCode("Invalid credit card number.", HttpStatusCode.BadRequest)]
        InvalidCreditCard = 85,

        [ErrorCode("Invalid IP address.", HttpStatusCode.BadRequest)]
        InvalidIPAddress = 86,

        [ErrorCode("Search query was empty.", HttpStatusCode.BadRequest)]
        SearchQueryEmpty = 87,

        [ErrorCode("Tee time no longer available.", HttpStatusCode.Gone)]
        TeeTimeNotAvailable = 88,

        [ErrorCode("The course ID specified is invalid.", HttpStatusCode.BadRequest)]
        InvalidCourseId = 89,

        [ErrorCode("The source system ID specified is invalid.", HttpStatusCode.BadRequest)]
        InvalidSourceSystemId = 90,

        [ErrorCode("The master course ID specified is invalid.", HttpStatusCode.BadRequest)]
        InvalidMasterCourseId = 91,

        [ErrorCode("The master course object was invalid.", HttpStatusCode.BadRequest)]
        InvalidMasterCourseObject = 92,

        [ErrorCode("The requested wallet operation is invalid.", HttpStatusCode.BadRequest)]
        InvalidWalletOperation = 93,

        [ErrorCode("Invalid value for eligibility verification type.", HttpStatusCode.BadRequest)]
        InvalidEligibilityVerificationType = 94,

        [ErrorCode("Service is unable to respond to request.", HttpStatusCode.BadGateway)]
        ServiceProviderError = 95,

        [ErrorCode("Invalid eligibility verification operation.", HttpStatusCode.PreconditionFailed)]
        InvalidEligibilityVerificationOperation = 96,

        [ErrorCode("Invalid guest access request", HttpStatusCode.BadRequest)]
        InvalidGuestAccessRequest = 97,
        
        [ErrorCode("Invalid URL.", HttpStatusCode.BadRequest)]
        InvalidUrl = 98,

        [ErrorCode("Invalid Opportunity ID.", HttpStatusCode.BadRequest)]
        InvalidOpportunityId = 99,
    }
}
