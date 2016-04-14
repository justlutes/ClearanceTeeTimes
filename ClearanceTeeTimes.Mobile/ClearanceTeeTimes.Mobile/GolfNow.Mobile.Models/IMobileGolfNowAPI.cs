using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;

using GolfNow.Mobile.Models.DataContracts;

//using GolfNow.Mobile.Models.Enumerations;
using GolfNow.Mobile.Models.Enumerations;



namespace GolfNow.Mobile.Api
{

    [Headers("Accept: application/json")]
    [Preserve(Conditional = true)]
    public interface IMobileGolfNowApi
    {



        /// <summary>
        ///Returns a list of valid organization names for eligibility verification.
        /// </summary>

        [Get("/lookups/eligibility-verification-organization-names?type={type}")]
        Task<String[]> GetEligibilityVerificationOrganizationNames(string type);



        /// <summary>
        ///Returns the master course record for a particular input ID.
        /// </summary>

        [Get("/mastercourse/search?id={mastercourseid}")]
        Task<MasterCourse> GetMasterCourse(string masterCourseId);



        /// <summary>
        ///Returns the master course record for a composite lookup consisting of source system ID and course ID.
        /// </summary>

        [Get("/mastercourse/searchcomposite?id={lookup}")]
        Task<MasterCourse> GetMasterCourseByCompositeId(MasterCourseCompositeLookup lookup);



        /// <summary>
        ///Creates a new master course.
        /// </summary>

        [Put("/mastercourse/create")]
        Task<MasterCourseStageResult> CreateMasterCourse([Body] MasterCourse masterCourse);



        /// <summary>
        ///Updates a master course.
        /// </summary>

        [Post("/mastercourse/update?id={masterCourseId}")]
        Task<MasterCourseStageResult> UpdateMasterCourse(string masterCourseId, [Body] MasterCourseUpdates updates);



        /// <summary>
        ///Gets the wallet and associated wallet information (payment options) for a customer.
        /// </summary>

        [Headers("CustomerToken: {Token}")]
        [Get("/customers/{customeremail}/wallet")]
        Task<Wallet> GetWallet(string customeremail);



        /// <summary>
        ///Validate and save (add or update) a payment option.
        /// </summary>

        [Post("/customers/{customeremail}/wallet")]
        [Headers("CustomerToken: {Token}")]
        Task SavePaymentOption(string customeremail, [Body] PaymentOptionBase paymentOption);



        /// <summary>
        ///Remove a credit card associated with a customer's wallet.
        /// </summary>

        [Headers("CustomerToken: {Token}")]
        [Delete("/customers/{customeremail}/wallet")]
        Task RemovePaymentOption(string customeremail, [Body] PaymentOptionBase paymentOption);



        /// <summary>
        ///Set this credit card as the default credit card to be used.
        /// </summary>

        [Post("/customers/{customeremail}/wallet/creditcard/setprimary")]
        [Headers("CustomerToken: {Token}")]
        Task SetCreditCardAsPrimary(string customeremail, [Body] CreditCardPaymentOption creditCard);



        /// <summary>
        ///Gets the related tee time rates for the tee time rate specified by a tee time rate ID
        /// </summary>

        [Get("/channel/{channelid}/tee-times/{teetimerateid}/related-rates")]
        Task<IEnumerable<TeeTimeRate>> GetRelatedTeeTimeRates(string channelid, string teetimerateid);



        /// <summary>
        ///Returns a guest token to be used in future guest data requests.
        /// </summary>

        [Post("/customers/{email}/guest-token?timeout={timeout}")]
        Task<string> GetGuestToken(string email, string timeout, [Body] GuestCredentials credentials);



        /// <summary>
        ///Creates a customer profile record.
        /// </summary>

        [Put("/customers?channelid={channelid}")]
        Task AddCustomer([Body] CustomerProfileNew input, string channelid);


	
        /// <summary>
        ///Gets a customer profile.  Expand loyalty status using 'LoyaltyStatus'.
        /// </summary>

        //		[Headers ("CustomerToken")]

        [Headers("CustomerToken: {Token}")]
        [Get("/customers/{customeremail}")]
        Task<CustomerProfileResponse> GetCustomer(string customeremail, [AliasAs("expand")] ExpandRequest options);



        /// <summary>
        ///Updates a customer.
        /// </summary>

        [Headers("CustomerToken: {Token}")]
        [Post("/customers/{customeremail}")]
        Task UpdateCustomer(string customeremail, [Body] CustomerProfile profile);



        /// <summary>
        ///Gets a list of a customer's favorite facility settings, optionally restricting by channel id.  Expand Teetimes using Facility.Ratesets.
        /// </summary>

        [Get("/customers/{customeremail}/favorite-facilities?channel={channelid}&expand={options}")]
        [Headers("CustomerToken: {Token}")]
        Task<FacilityDetail[]> GetFavoriteFacilities(string customeremail, Int32 channelid, ExpandRequest options);



        /// <summary>
        ///Adds a facility to a customer's favorite facilities.
        /// </summary>

        [Put("/customers/{customeremail}/favorite-facilities/{facilityid}")]
        [Headers("CustomerToken: {Token}")]
        Task AddFavoriteFacility(string customeremail, string facilityid);



        /// <summary>
        ///Removes a facility from a customer's favorite facilities.
        /// </summary>

        [Headers("CustomerToken: {Token}")]
        [Delete("/customers/{customeremail}/favorite-facilities/{facilityid}")]
        Task DeleteFavoriteFacility(string customeremail, string facilityid);



        /// <summary>
        ///Gets a particular favorite facility from the specified inventory channel.
        /// </summary>

        [Get("/customers/{customeremail}/favorite-facilities/{facilityid}?channel={channelid}")]
        [Headers("CustomerToken: {Token}")]
        Task<FacilityDetail> GetFavoriteFacility(string customeremail, string facilityid, Int32 channelid);



        /// <summary>
        ///Validates a customer token against to be sure that it can be used to access customer data.
        /// </summary>
        [Headers("Content-Type: application/json")]  
        [Post("/customers/{customeremail}/authentication-token/validate")]
        Task<Boolean> ValidateCustomerToken(string customeremail, [Body] string token);



        /// <summary>
        ///Authenticates a customer and returns an authentication token to be used in future customer data requests.
        /// </summary>

        [Post("/customers/{email}/authentication-token?timeout={timeout}")]
        Task<string> GetCustomerToken(string email, string timeout, [Body] CustomerCredentials credentials);



        /// <summary>
        ///Gets a list of a customer's golf buddies.
        /// </summary>

        [Get("/customers/{customeremail}/golf-buddies")]
        [Headers("CustomerToken: {Token}")]
        Task<GolfBuddyDetails[]> GetGolfBuddies(string customeremail);



        /// <summary>
        ///Adds a golf buddy to a customer's list.
        /// </summary>

        [Put("/customers/{customeremail}/golf-buddies")]
        [Headers("CustomerToken: {Token}")]
        Task AddGolfBuddy(string customeremail, [Body] GolfBuddy buddy);



        /// <summary>
        ///Updates a golf buddy in the customer's list.
        /// </summary>

        [Post("/customers/{customeremail}/golf-buddies/{golfbuddyemail}")]
        [Headers("CustomerToken: {Token}")]
        Task UpdateGolfBuddy(string customeremail, string golfbuddyemail, [Body] GolfBuddy buddy);



        /// <summary>
        ///Delete a golf buddy from the customer's list.
        /// </summary>

        [Delete("/customers/{customeremail}/golf-buddies/{golfbuddyemail}")]
        [Headers("CustomerToken: {Token}")]
        Task DeleteGolfBuddy(string customeremail, string golfbuddyemail);



        /// <summary>
        ///A tee time invoice with pricing details for the specified number of players.
        /// </summary>

        [Get("/channel/{channelid}/facilities/{facilityid}/tee-times/{teetimerateid}/invoice/customer-invoice?customeremail={customeremail}&player-count={playercount}&promo-code={promocode}&verify={verify}")]
        [Headers("CustomerToken: {Token}")]
        Task<TeeTimeInvoice> GetTeeTimeInvoiceForCustomer(string customeremail, string channelid, string facilityid, string teetimerateid, string playercount, string promocode, string verify);



        /// <summary>
        ///Request a tee time invoice while applying a rate override.
        /// </summary>

        [Post("/channel/{channelid}/facilities/{facilityid}/tee-times/{teetimerateid}/invoice/customer-invoice?q=rateoverride&customeremail={customeremail}&player-count={playercount}&promo-code={promocode}&verify={verify}")]
        [Headers("CustomerToken: {Token}")]
        Task<TeeTimeInvoice> RequestOverrideTeeTimeInvoiceForCustomer(string customeremail, string channelid, string facilityid, string teetimerateid, string playercount, string promocode, string verify, [Body] RateOverride overridePricing);



        /// <summary>
        ///Books a tee time on the golf now system and returns the resulting reservation confirmation.
        /// </summary>

        [Post("/customers/{customeremail}/reservations")]
        //[Headers ("CustomerToken: {Token}")]
		Task<ReservationConfirmation> AddReservation(string customeremail, [Body] ReservationClaim reservation);



        /// <summary>
        ///Gets a reservation from a customer's reservation list.
        /// </summary>

        [Get("/customers/{customeremail}/reservations/{reservationid}")]
        [Headers("CustomerToken: {Token}")]
        Task<ReservationConfirmationDetail> GetReservation(string customeremail, string reservationid);



        /// <summary>
        ///Sends or resends a confirmation email for a reservation based on the input provided.
        /// </summary>

        [Post("/customers/{customeremail}/reservations/{reservationid}/confirmation-emails")]
        [Headers("CustomerToken: {Token}")]
        Task SendConfirmationEmail(string customeremail, string reservationid, [Body] ConfirmationEmailRequest request);



        /// <summary>
        ///Sends "Forward to a Friend", confirmation, and cancellation emails based on a reservation.
        /// </summary>

        [Post("/customers/{customeremail}/reservations/{reservationid}/reservation-emails")]
        [Headers("CustomerToken: {Token}")]
        Task SendReservationEmail(string customeremail, string reservationid, [Body] ConfirmationEmailRequest request);



        /// <summary>
        ///Gets a list of a customer's reservations.
        /// </summary>

        [Get("/customers/{customeremail}/reservations?")]
        //play-date-min={playdatemin}&play-date-max={playdatemax}&expand={options}&take={take}&skip={skip}&sort-by={sortby}&sort-direction={sortdirection}&channelid={channelid}
		//[Headers ("CustomerToken: {Token}")]
		Task<ReservationConfirmationCollection> GetReservations(string customeremail, [AliasAs("play-date-min")] string playdatemin, [AliasAs("play-date-max")] string playdatemax, [AliasAs("expand")] ExpandRequest options, [AliasAs("take")] string take, [AliasAs("skip")] string skip, [AliasAs("sort-by")] string sortby, [AliasAs("sort-direction")] string sortdirection, [AliasAs("channelid")] string channelid = null, [AliasAs("fields")] string fields = null);



        /// <summary>
        ///Gets a list of facilities that are in the given customer's resident facility list.
        /// </summary>

        [Headers("CustomerToken: {Token}")]
        [Get("/customers/{customeremail}/resident-facilities")]
        Task<Facility[]> GetResidentFacilities(string customeremail);



        /// <summary>
        ///Puts the facility into the given customer's resident facility list.
        /// </summary>

        [Headers("CustomerToken: {Token}")]
        [Put("/customers/{customeremail}/resident-facilities/{facilityid}")]
        Task AddResidentFacility(string customeremail, string facilityid);



        /// <summary>
        ///Deletes the facility from the given customer's resident facility list.
        /// </summary>

        [Delete("/customers/{customeremail}/resident-facilities/{facilityid}")]
        [Headers("CustomerToken: {Token}")]
        Task RemoveResidentGolfFacility(string customeremail, string facilityid);



        /// <summary>
        ///Returns true when the service is working.
        /// </summary>

        [Get("/system/statuses/is-alive")]
        Task<Boolean> IsAlive();



        /// <summary>
        ///Echos the input back to the client if the client is authenticated.
        /// </summary>

        [Post("/system/status/secure-echo")]
        Task<string> SecureEcho([Body] string input);



        /// <summary>
        ///Returns a list of countries assigned to the inventory unit.
        /// </summary>

        [Get("/channel/{channelid}/countries")]
        Task<Country[]> GetCountries(string channelid);



        /// <summary>
        ///Returns a list of countries by code and name.
        /// </summary>


        [Get("/lookups/countries")]
        Task<Country[]> GetAllCountries();



        /// <summary>
        ///Return a list of states or provinces associated with a country code.
        /// </summary>

        [Get("/lookups/countries/{countrycode}/state-provinces")]
        Task<StateProvince[]> GetStatesByCountryCode(string countrycode);



        /// <summary>
        ///Returns a list of states and provinces that match the country code.
        /// </summary>

        [Get("/channel/{channelid}/countries/{countrycode}/state-provinces")]
        Task<StateProvince[]> GetStates(string channelid, string countrycode);



        /// <summary>
        ///Returns a list of cities that match the state province code and country code.
        /// </summary>

        [Get("/channel/{channelid}/countries/{countrycode}/state-provinces/{stateprovincecode}/cities")]
        Task<City[]> GetCities(string channelid, string countrycode, string stateprovincecode);



        /// <summary>
        ///Gets a list of facilities for a given country, state/province and city.
        /// </summary>

        [Get("/channel/{channelid}/facilities?q=list&skip={skip}&take={take}&expand={options}")]
        Task<FacilityDetail[]> GetFacilitiesByChannel(string channelid, string skip, string take, ExpandRequest options);



        /// <summary>
        ///Gets a list of facilities for a given country, state/province and city.
        /// </summary>

        [Get("/channel/{channelid}/facilities?q=country-city-state&country-code={countrycode}&state-province-code={stateprovincecode}&city={city}&tags={tags}&expand={options}")]
        Task<FacilityDetail[]> GetFacilitiesByCity(string channelid, string countrycode, string stateprovincecode, string city, string tags, ExpandRequest options);



        /// <summary>
        ///Retrieves a facility by facility and channel ID.
        /// </summary>

        [Get("/channel/{channelid}/facilities/{facilityid}?expand={options}")]
        Task<FacilityDetail> GetFacility(string channelid, string facilityid, ExpandRequest options);



        /// <summary>
        ///Retrieves information about the input tee time list.
        /// </summary>

        [Post("/channel/{channelid}/tee-time-rate-update-requests")]
        Task<TeeTimeRate[]> RequestTeeTimeUpdates(string channelid, [Body] TeeTimeBatchLookupRequest request);



        /// <summary>
        ///Gets a list of tee times for the specified facility that match the predicates.
        /// </summary>

        [Get("/channel/{channelid}/facilities/{facilityid}/tee-times?date-min={datemin}&date-max={datemax}&price-min={pricemin}&price-max={pricemax}&holes={holecount}&players={playercount}&ratetags={ratetags}&ratetype={ratetype}&time-min={timemin}&time-max={timemax}&expand={options}&take={take}&skip={skip}&sort-by={sortby}&sort-direction={sortdirection}&mode={mode}")]
        Task<TeeTimeCollection> GetTeeTimesByFacility(string channelid, string facilityid, string datemin, string datemax, string pricemin, string pricemax, string playercount, string ratetags, string timemin, string timemax, string holecount, ExpandRequest options, string take, string skip, string sortby, string sortdirection, string ratetype, string mode);



        /// <summary>
        ///Gets a list of tee time rate cards that are closest in time to the specified tee time.
        /// </summary>

        [Get("/channel/{channelid}/facilities/{facilityid}/tee-times/{teetimerateid}/adjacent-tee-times?player-count={minplayercount}&take={take}")]
        Task<TeeTimeRateset[]> GetAdjacentTeeTimes(string channelid, string facilityid, string teetimerateid, string minplayercount, string take);



        /// <summary>
        ///Gets a list of top deals.
        /// </summary>

        [Get("/channel/{channelid}/facilities/top-deals?take={take}")]
        Task<TopDealsResponse> GetTopDeals(string channelid, string take);



        /// <summary>
        ///Gets a list of courses with the best rates for the specified criteria.
        /// </summary>

        [Get("/channel/{channelid}/facilities/best-rates?latitude={latitude}&longitude={longitude}&proximity={radius}&start-date={startdate}&end-date={enddate}")]
        Task<FacilityRate[]> GetBestRates(string channelid, Single latitude, Single longitude, Int32 radius, string startdate, string enddate);



        /// <summary>
        ///A tee time invoice with pricing details for the specified number of players.
        /// </summary>

        [Get("/channel/{channelid}/facilities/{facilityid}/tee-times/{teetimerateid}/invoice?player-count={playercount}&verify={verify}")]
        Task<TeeTimeInvoice> GetTeeTimeInvoice(string channelid, string facilityid, string teetimerateid, string playercount, string verify);




        /// <summary>
        ///Gets a list of market associated with the particular distribution channel.
        /// </summary>

        [Get("/channel/{channelid}/markets")]
        Task<Market[]> GetMarkets(string channelid);



        /// <summary>
        ///Gets market by distribution channel and market id.
        /// </summary>

        [Get("/channel/{channelid}/markets/{marketid}")]
        Task<Market> GetMarket(string channelid, string marketid);



        /// <summary>
        ///Gets a list of facilities in a distribution channel that are within a particular market.
        /// </summary>

        [Get("/channel/{channelid}/markets/{marketid}/facilities?tags={tags}&expand={options}")]
        Task<FacilityDetail[]> GetFacilitiesByMarket(string channelid, string marketid, string tags, ExpandRequest options);



        /// <summary>
        ///Returns a list of markets that match the state/province code and country code.
        /// </summary>

        [Get("/channel/{channelid}/countries/{countrycode}/state-provinces/{stateprovincecode}/markets")]
        Task<Market[]> GetMarketsByState(string channelid, string countrycode, string stateprovincecode);



        /// <summary>
        ///Returns important messages relating to particular inventory channel.
        /// </summary>

        [Get("/channel/{channelid}/messages")]
        Task<String[]> GetMessages(string channelid);



        /// <summary>
        ///Returns geographic information about a postal code.
        /// </summary>

        [Get("/lookups/postal-codes/{postalcode}/geographic-information")]
        Task<GeographicInformation> GetGeographicInformationByPostalCode(string postalcode);



        /// <summary>
        ///Returns approximate geographic information about an IP address.
        /// </summary>

        [Get("/lookups/ip-addresses/{ipaddress}/geographic-information")]
        Task<GeographicInformation> GetGeographicInformationByIPAddress(string ipaddress);



        /// <summary>
        ///Returns user ratings associated with a facility.
        /// </summary>

        [Get("/channel/{channelid}/facilities/{facilityid}/reviews?take={take}&skip={skip}&sort-by={sortby}&sort-direction={sortdirection}")]
        Task<ReviewCollection> GetRatingsByFacility(string channelid, string facilityid, string take, string skip, string sortby, string sortdirection);



        /// <summary>
        ///Returns a list of facilities based on a text-based 'contains' query of the Name and City properties.
        /// </summary>

        [Get("/channel/{channelid}/facilities?q=name-city&name-city-value={query}&nameOnly={nameOnly}")]
        Task<FacilityDetail[]> GetFacilitiesByNameCityContainsQuery(string channelid, string query, Boolean nameOnly);



        /// <summary>
        ///Returns a list of facilities that have been flagged as featured on the specified channel.
        /// </summary>

        [Get("/channel/{channelid}/facilities/featured")]
        Task<FacilityDetail[]> GetFeaturedFacilities(string channelid);



        /// <summary>
        ///Returns any customer subscription lists that are available to current client.
        /// </summary>

        [Get("/lookups/customer-subscription-lists")]
        Task<CustomerSubscriptionList[]> GetSubscriptionLists();



        /// <summary>
        ///Returns potential subscriptions for an input zip code.
        /// </summary>

        [Get("/lookups/{zipcode}/customer-subscription-lists")]
        Task<Subscription[]> GetSubscriptionsByZipCode(string zipcode);



        /// <summary>
        ///Gets a customers subscription status to a customer subscription list.
        /// </summary>

        [Get("/customers/{customeremail}/customer-subscription-list/{subscriptionlistid}")]
        [Headers("CustomerToken: {Token}")]
        Task<CustomerSubscriptionStatus> GetSubscriptionStatus(string customeremail, string subscriptionlistid);



        /// <summary>
        ///Updates a customers subscription status to a customer subscription list.
        /// </summary>

        [Headers("CustomerToken: {Token}")]
        [Post("/customers/{customeremail}/customer-subscription-list/{subscriptionlistid}?callbackUrl={callbackUrl}")]
        Task UpdateSubscriptionStatus(string customeremail, string subscriptionlistid, [Body] CustomerSubscriptionStatus status, string callbackUrl);



        /// <summary>
        ///Sends a forgot password email to the specified customer.
        /// </summary>

        [Post("/customers/{customeremail}/forgot-password-emails")]
        Task SendForgotPasswordEmail(string customeremail);



        /// <summary>
        ///Sends a forgot password email to the specified customer.
        /// </summary>

        [Post("/customers/{customeremail}/forgot-password-emails?q=channel&channelid={channelid}")]
        Task SendForgotPasswordEmailByChannel(string customeremail, string channelid, [Body] SendForgotPasswordEmailRequest request);



        /// <summary>
        ///Validate a token sent by the "forgot password" process.
        /// </summary>

        [Post("/customers/validate-reset-token")]
        Task<Boolean> ValidateForgotPasswordToken([Body] ValidateTokenRequest request);



        /// <summary>
        ///Process a password reset request for a customer. The rules presently state that the new password be eight or more characters long, contain no spaces, and have at least one letter and one numeric character.
        /// </summary>

        [Post("/customers/reset-password")]
        Task<Boolean> ResetPassword([Body] ResetPasswordTokenRequest request);



        /// <summary>
        ///Returns an agreement statement that matches the specified id.
        /// </summary>

        [Get("/lookups/agreement-statements/{agreementstatementid}")]
        Task<string> GetAgreement(string agreementstatementid);



        /// <summary>
        ///Returns a list of coupons that are available for the specified inventory channel.
        /// </summary>

        [Get("/channel/{channelid}/coupons")]
        Task<String[][]> GetCoupons(string channelid);



        /// <summary>
        ///Returns various settings for the specified inventory channel.
        /// </summary>

        [Get("/channel/{channelid}/settings")]
        Task<ChannelSettings> GetChannelSettings(string channelid);



        /// <summary>
        ///Returns a list of facilities that are within a specified proximity to a postal code.
        /// </summary>

        [Get("/channel/{channelid}/facilities?q=postal-code&postal-code={postalcode}&proximity={proximity}&minplayercount={minplayercount}&tags={tags}&expand={options}")]
        Task<FacilityDetail[]> GetFacilitiesByPostalCode(string channelid, string postalcode, Int32 proximity, string minplayercount, string tags, ExpandRequest options);



        /// <summary>
        ///Returns a list of facilities that are within a specified proximity to a geographic coordinate.
        /// </summary>

        [Get("/channel/{channelid}/facilities?q=geo-location")]
        Task<FacilityDetail[]> GetFacilitiesByGeoLocation(string channelid, [AliasAs("latitude")] Single latitude, [AliasAs("longitude")]Single longitude, [AliasAs("proximity")] Int32 proximity, [AliasAs("minplayercount")] string playercount, [AliasAs("date-min")] string datemin, [AliasAs("date-max")] string datemax, [AliasAs("tags")]string facilitytags, [AliasAs("expand")] ExpandRequest options, [AliasAs("fields")] string fields);

        /// <summary>
        ///Queries for tee times that match the specified geo-location query.
        /// </summary>
        [Get("/channel/{channelid}/facilities/tee-times?q=geo-location")]
        Task<TeeTimeCollection> GetTeeTimesByGeoLocation(string channelid, [AliasAs("latitude")] Single latitude, [AliasAs("longitude")]Single longitude, [AliasAs("proximity")] Int32 proximity, [AliasAs("price-min")]string pricemin, [AliasAs("price-max")] string pricemax, [AliasAs("player-count")] string playercount, [AliasAs("facilitytags")]string facilitytags, [AliasAs("ratetags")] string ratetags, [AliasAs("date-min")] string datemin, [AliasAs("date-max")] string datemax, [AliasAs("time-min")] string timemin, [AliasAs("time-max")]string timemax, [AliasAs("holes")] string holecount, [AliasAs("expand")] ExpandRequest options, [AliasAs("take")] string take, [AliasAs("skip")] string skip, [AliasAs("sort-by")] string sortby, [AliasAs("sort-direction")] string sortdirection, [AliasAs("ratetype")] string ratetype, [AliasAs("mode")] string mode, [AliasAs("fields")] string fields, [AliasAs("trade-only")] string tradeonly);

        /// <summary>
        ///Gets a list of all available rate tags including descriptions , description and Image Uri.
        /// </summary>

        [Get("/lookups/rate-tags")]
        Task<RateTag[]> GetRateTags();



        /// <summary>
        ///Return a rate tag based on tagcode provided.
        /// </summary>

        [Get("/lookups/rate-tags/{tagcode}")]
        Task<RateTag> GetRateTag(string tagcode);



        /// <summary>
        ///Gets the weather for a specified postal code.
        /// </summary>

        [Get("//channel/{channelid}/countries/{countrycode}/weather?postal-code={postalcode}")]
        Task<WeatherForcast[]> GetWeather(string channelid, string countrycode, string postalcode);



        /// <summary>
        ///Gets public user information about a user by the customer's GUID.
        /// </summary>

        [Get("/customers/user-info?q=guid&id={customerguid}")]
        Task<UserInfo> GetCustomerUserInfoByGuid(string customerguid);



        /// <summary>
        ///Gets public user information about a user by the customer's email address.
        /// </summary>

        [Get("/customers/user-info?q=email&email={customeremail}")]
        Task<UserInfo> GetCustomerUserInfoByEmail(string customeremail);



        /// <summary>
        ///Gets public user information about a user by the customer's username.
        /// </summary>

        [Get("/customers/user-info?q=username&id={username}")]
        Task<UserInfo> GetCustomerUserInfoByUserName(string username);



        /// <summary>
        ///Changes a customer's password.
        /// </summary>

        [Post("/customers/{customeremail}/password")]
        Task ChangeCustomerPassword(string customeremail, [Body] PasswordChangeRequest request);



        /// <summary>
        ///Generates a redirect for the booking uri for the specified tee time rate and channel.
        /// </summary>

        [Get("/channel/{channelid}/facilities/{facilityid}/tee-times/{teetimerateid}/reservation-uri?redirect={redirect}&player-count={playercount}")]
        Task<string> GetBookingUri(string channelid, string facilityid, string teetimerateid, string playercount, string redirect);

        /// <summary>
        ///Queries for tee times for the specified channel and criteria.
        /// </summary>

        //		[Get ("/channel/{channelid}/facilities/tee-times?q=channel&players={playercount}&holes={holecount}&date-min={datemin}&date-max={datemax}&time-min={timemin}&time-max={timemax}&facilitytags={facilitytags}&price-min={pricemin}&price-max={pricemax}&ratetags={ratetags}&ratetype={ratetype}&skip={skip}&take={take}&sort-by={sortby}&sort-direction={sortdirection}&expand={options}&mode={mode}")]
        //		[Get ("/channel/{channelid}/facilities/tee-times?q=channel&players={playercount}&holes={holecount}&date-min={datemin}&date-max={datemax}&time-min={timemin}&time-max={timemax}&facilitytags={facilitytags}&price-min={pricemin}&price-max={pricemax}&ratetags={ratetags}&ratetype={ratetype}&skip={skip}&take={take}&sort-by={sortby}&sort-direction={sortdirection}&expand={options}&mode={mode}")]
        //		Task<TeeTimeCollection> GetTeeTimesByChannel (string channelid, [AliasAs ("players")] string playercount, [AliasAs ("holes")] string holecount, [AliasAs ("date-min")]string datemin, [AliasAs ("date-max")]string datemax, [AliasAs ("time-min")]string timemin, [AliasAs ("time-max")]string timemax, [AliasAs ("facilitytags")] string facilitytags, [AliasAs ("price-min")] string pricemin, [AliasAs ("price-max")] string pricemax, [AliasAs ("ratetags")] string ratetags, [AliasAs ("skip")] string skip, [AliasAs ("take")]string take, [AliasAs ("sort-by")]string sortby, [AliasAs ("sort-direction")]string sortdirection, [AliasAs ("expand")]ExpandRequest options, [AliasAs ("ratetype")] string ratetype, [AliasAs ("mode")] string mode);



        /// <summary>
        ///Queries for tee times that match the specified market and query.
        /// </summary>

        [Get("/channel/{channelid}/facilities/tee-times?q=market&market-id={marketid}&date-min={datemin}&date-max={datemax}&price-min={pricemin}&price-max={pricemax}&holes={holecount}&players={playercount}&facilitytags={facilitytags}&ratetags={ratetags}&ratetype={ratetype}&time-min={timemin}&time-max={timemax}&expand={options}&take={take}&skip={skip}&sort-by={sortby}&sort-direction={sortdirection}&mode={mode}")]
        Task<TeeTimeCollection> GetTeeTimesByMarket(string channelid, Int32 marketid, string pricemin, string pricemax, string playercount, string facilitytags, string ratetags, string datemin, string datemax, string timemin, string timemax, string holecount, ExpandRequest options, string take, string skip, string sortby, string sortdirection, string ratetype, string mode);



        /// <summary>
        ///Queries for facilities at a given latitude and longitude, amalgamating their tee times.
        /// </summary>

        [Get("/channel/{channelid}/facility-summaries?q=geolocation")]
        Task<FacilitySummaryCollection> GetFacilitySummariesByGeolocation(string channelid, Single latitude, Single longitude, Int32 proximity, string pricemin, string pricemax, string playercount, string facilitytags, string ratetags, string datemin, string datemax, string timemin, string timemax, string holecount, string take, string skip, string sortby, string sortdirection, string ratetype, [AliasAs("expand")] ExpandRequest options, [AliasAs("fields")] string fields, [AliasAs("trade-only")] string tradeonly);



        /// <summary>
        ///Sets a value indicating that the customer's email address has been verified.  Currently, only true is accepted.
        /// </summary>

        [Post("/customers/{customeremail}/email-verified")]
        Task SetIsEmailVerified(string customeremail, [Body] Boolean isemailverified);



        /// <summary>
        ///Provides clients with the ability to store customer purchase data.
        /// </summary>

        [Post("/channel/{channelid}/purchases?purchase-id={purchaseid}")]
        Task<PurchaseStatus> AddPurchase(string channelid, string purchaseid, [Body] Purchase purchase);



        /// <summary>
        ///Provides clients with the ability to retrieve stored purchase data from the GolfNow system.
        /// </summary>

        [Get("/channel/{channelid}/purchases/{purchaseid}")]
        Task<Purchase> GetPurchase(string channelid, string purchaseid);



        /// <summary>
        ///Returns status information for a purchase by a customer.
        /// </summary>

        [Get("/channel/{channelid}/purchases/status?email={customeremail}&product-id={productid}")]
        Task<PurchaseStatus> GetPurchaseStatus(string channelid, string customeremail, string productid);



        /// <summary>
        ///Adds a promo code to customer's account and sends an email to the customer.
        /// </summary>

        [Post("/customers/{customeremail}/promo-codes")]
        Task<PromoCode> AddPromoCode(string customeremail, [Body] PromoCodeInfo promoCodeInfo);



        /// <summary>
        ///Gets the current rewards status for a customer.
        /// </summary>

        [Get("/customers/{customeremail}/rewards")]
        [Headers("CustomerToken: {Token}")]
        Task<Rewards> GetRewardsStatus(string customeremail);



        /// <summary>
        ///Returns the list of valid promo codes for the customer.
        /// </summary>

        [Get("/customers/{customeremail}/promo-codes")]
        [Headers("CustomerToken: {Token}")]
        Task<PromoCodeCollection> GetPromoCodes(string customeremail);



        /// <summary>
        ///Returns high-level information about areas within the GolfNow system.
        /// </summary>

        [Get("/search/areas?input={input}&resultcount={resultcount}")]
        Task<AreaSearchResult> SearchAreas(string input, Int32 resultcount);



        /// <summary>
        ///Returns high-level information about facilities within the GolfNow system.
        /// </summary>

        [Get("/search/facilities?input={input}&resultcount={resultcount}&channelid={channelid}&tags={tags}&include-tags={includetags}&fields={fields}")]
        Task<FacilitySearchResult> SearchFacilities(string input, Int32 resultcount, string channelid = null, string tags = null, string includeTags = null, string fields = null);



        /// <summary>
        ///Looks up the eligibility of a customer for specific types of verification.
        /// </summary>

        [Get("/customers/{customeremail}/eligibility?verification-type={verificationtypes}&status-start-date={statusstartdate}&organization-name={organizationname}&resubmit={resubmit}&lookupcacheonly={lookupcacheonly}")]
        [Headers("CustomerToken: {Token}")]
        Task<CustomerEligibility> GetCustomerEligibility(string customeremail, string verificationtypes, string statusstartdate, string organizationname, string resubmit, string lookupcacheonly);



        /// <summary>
        ///Requests a review of provided documentation to verify customer eligibility.
        /// </summary>

        [Headers("CustomerToken: {Token}")]
        [Post("/customers/{customeremail}/eligibility/reviews")]
        Task<DocumentationReviewRequestResult> RequestEligibilityDocumentationReview(string customeremail, [Body] DocumentationReviewRequest reviewrequest);




    }




}

