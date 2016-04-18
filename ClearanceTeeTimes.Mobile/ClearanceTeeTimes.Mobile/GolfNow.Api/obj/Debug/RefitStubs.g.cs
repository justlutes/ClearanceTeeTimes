﻿﻿using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Refit;
using GolfNow.Mobile.Models.DataContracts;
using GolfNow.Mobile.Models.Enumerations;
using GolfNow.Mobile.Models;

/* ******** Hey You! *********
 *
 * This is a generated file, and gets rewritten every time you build the
 * project. If you want to edit it, you need to edit the mustache template
 * in the Refit package */

namespace RefitInternalGenerated
{
    [AttributeUsage (AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Delegate)]
    sealed class PreserveAttribute : Attribute
    {
#pragma warning disable 0649
        //
        // Fields
        //
        public bool AllMembers;

        public bool Conditional;
#pragma warning restore 0649
    }
}

namespace GolfNow.Mobile.Api
{
    using RefitInternalGenerated;

    [Preserve]
    public partial class AutoGeneratedIMobileGolfNowApi : IMobileGolfNowApi
    {
        public HttpClient Client { get; protected set; }
        readonly Dictionary<string, Func<HttpClient, object[], object>> methodImpls;

        public AutoGeneratedIMobileGolfNowApi(HttpClient client, IRequestBuilder requestBuilder)
        {
            methodImpls = requestBuilder.InterfaceHttpMethods.ToDictionary(k => k, v => requestBuilder.BuildRestResultFuncForMethod(v));
            Client = client;
        }

        public virtual Task<String[]> GetEligibilityVerificationOrganizationNames(string type)
        {
            var arguments = new object[] { type };
            return (Task<String[]>) methodImpls["GetEligibilityVerificationOrganizationNames"](Client, arguments);
        }

        public virtual Task<MasterCourse> GetMasterCourse(string masterCourseId)
        {
            var arguments = new object[] { masterCourseId };
            return (Task<MasterCourse>) methodImpls["GetMasterCourse"](Client, arguments);
        }

        public virtual Task<MasterCourse> GetMasterCourseByCompositeId(MasterCourseCompositeLookup lookup)
        {
            var arguments = new object[] { lookup };
            return (Task<MasterCourse>) methodImpls["GetMasterCourseByCompositeId"](Client, arguments);
        }

        public virtual Task<MasterCourseStageResult> CreateMasterCourse(MasterCourse masterCourse)
        {
            var arguments = new object[] { masterCourse };
            return (Task<MasterCourseStageResult>) methodImpls["CreateMasterCourse"](Client, arguments);
        }

        public virtual Task<MasterCourseStageResult> UpdateMasterCourse(string masterCourseId,MasterCourseUpdates updates)
        {
            var arguments = new object[] { masterCourseId,updates };
            return (Task<MasterCourseStageResult>) methodImpls["UpdateMasterCourse"](Client, arguments);
        }

        public virtual Task<Wallet> GetWallet(string customeremail)
        {
            var arguments = new object[] { customeremail };
            return (Task<Wallet>) methodImpls["GetWallet"](Client, arguments);
        }

        public virtual Task SavePaymentOption(string customeremail,PaymentOptionBase paymentOption)
        {
            var arguments = new object[] { customeremail,paymentOption };
            return (Task) methodImpls["SavePaymentOption"](Client, arguments);
        }

        public virtual Task RemovePaymentOption(string customeremail,PaymentOptionBase paymentOption)
        {
            var arguments = new object[] { customeremail,paymentOption };
            return (Task) methodImpls["RemovePaymentOption"](Client, arguments);
        }

        public virtual Task SetCreditCardAsPrimary(string customeremail,CreditCardPaymentOption creditCard)
        {
            var arguments = new object[] { customeremail,creditCard };
            return (Task) methodImpls["SetCreditCardAsPrimary"](Client, arguments);
        }

        public virtual Task<IEnumerable<TeeTimeRate>> GetRelatedTeeTimeRates(string channelid,string teetimerateid)
        {
            var arguments = new object[] { channelid,teetimerateid };
            return (Task<IEnumerable<TeeTimeRate>>) methodImpls["GetRelatedTeeTimeRates"](Client, arguments);
        }

        public virtual Task<string> GetGuestToken(string email,string timeout,GuestCredentials credentials)
        {
            var arguments = new object[] { email,timeout,credentials };
            return (Task<string>) methodImpls["GetGuestToken"](Client, arguments);
        }

        public virtual Task AddCustomer(CustomerProfileNew input,string channelid)
        {
            var arguments = new object[] { input,channelid };
            return (Task) methodImpls["AddCustomer"](Client, arguments);
        }

        public virtual Task<CustomerProfileResponse> GetCustomer(string customeremail,ExpandRequest options)
        {
            var arguments = new object[] { customeremail,options };
            return (Task<CustomerProfileResponse>) methodImpls["GetCustomer"](Client, arguments);
        }

        public virtual Task UpdateCustomer(string customeremail,CustomerProfile profile)
        {
            var arguments = new object[] { customeremail,profile };
            return (Task) methodImpls["UpdateCustomer"](Client, arguments);
        }

        public virtual Task<FacilityDetail[]> GetFavoriteFacilities(string customeremail,Int32 channelid,ExpandRequest options)
        {
            var arguments = new object[] { customeremail,channelid,options };
            return (Task<FacilityDetail[]>) methodImpls["GetFavoriteFacilities"](Client, arguments);
        }

        public virtual Task AddFavoriteFacility(string customeremail,string facilityid)
        {
            var arguments = new object[] { customeremail,facilityid };
            return (Task) methodImpls["AddFavoriteFacility"](Client, arguments);
        }

        public virtual Task DeleteFavoriteFacility(string customeremail,string facilityid)
        {
            var arguments = new object[] { customeremail,facilityid };
            return (Task) methodImpls["DeleteFavoriteFacility"](Client, arguments);
        }

        public virtual Task<FacilityDetail> GetFavoriteFacility(string customeremail,string facilityid,Int32 channelid)
        {
            var arguments = new object[] { customeremail,facilityid,channelid };
            return (Task<FacilityDetail>) methodImpls["GetFavoriteFacility"](Client, arguments);
        }

        public virtual Task<Boolean> ValidateCustomerToken(string customeremail,string token)
        {
            var arguments = new object[] { customeremail,token };
            return (Task<Boolean>) methodImpls["ValidateCustomerToken"](Client, arguments);
        }

        public virtual Task<string> GetCustomerToken(string email,string timeout,CustomerCredentials credentials)
        {
            var arguments = new object[] { email,timeout,credentials };
            return (Task<string>) methodImpls["GetCustomerToken"](Client, arguments);
        }

        public virtual Task<GolfBuddyDetails[]> GetGolfBuddies(string customeremail)
        {
            var arguments = new object[] { customeremail };
            return (Task<GolfBuddyDetails[]>) methodImpls["GetGolfBuddies"](Client, arguments);
        }

        public virtual Task AddGolfBuddy(string customeremail,GolfBuddy buddy)
        {
            var arguments = new object[] { customeremail,buddy };
            return (Task) methodImpls["AddGolfBuddy"](Client, arguments);
        }

        public virtual Task UpdateGolfBuddy(string customeremail,string golfbuddyemail,GolfBuddy buddy)
        {
            var arguments = new object[] { customeremail,golfbuddyemail,buddy };
            return (Task) methodImpls["UpdateGolfBuddy"](Client, arguments);
        }

        public virtual Task DeleteGolfBuddy(string customeremail,string golfbuddyemail)
        {
            var arguments = new object[] { customeremail,golfbuddyemail };
            return (Task) methodImpls["DeleteGolfBuddy"](Client, arguments);
        }

        public virtual Task<TeeTimeInvoice> GetTeeTimeInvoiceForCustomer(string customeremail,string channelid,string facilityid,string teetimerateid,string playercount,string promocode,string verify)
        {
            var arguments = new object[] { customeremail,channelid,facilityid,teetimerateid,playercount,promocode,verify };
            return (Task<TeeTimeInvoice>) methodImpls["GetTeeTimeInvoiceForCustomer"](Client, arguments);
        }

        public virtual Task<TeeTimeInvoice> RequestOverrideTeeTimeInvoiceForCustomer(string customeremail,string channelid,string facilityid,string teetimerateid,string playercount,string promocode,string verify,RateOverride overridePricing)
        {
            var arguments = new object[] { customeremail,channelid,facilityid,teetimerateid,playercount,promocode,verify,overridePricing };
            return (Task<TeeTimeInvoice>) methodImpls["RequestOverrideTeeTimeInvoiceForCustomer"](Client, arguments);
        }

        public virtual Task<ReservationConfirmation> AddReservation(string customeremail,ReservationClaim reservation)
        {
            var arguments = new object[] { customeremail,reservation };
            return (Task<ReservationConfirmation>) methodImpls["AddReservation"](Client, arguments);
        }

        public virtual Task<ReservationConfirmationDetail> GetReservation(string customeremail,string reservationid)
        {
            var arguments = new object[] { customeremail,reservationid };
            return (Task<ReservationConfirmationDetail>) methodImpls["GetReservation"](Client, arguments);
        }

        public virtual Task SendConfirmationEmail(string customeremail,string reservationid,ConfirmationEmailRequest request)
        {
            var arguments = new object[] { customeremail,reservationid,request };
            return (Task) methodImpls["SendConfirmationEmail"](Client, arguments);
        }

        public virtual Task SendReservationEmail(string customeremail,string reservationid,ConfirmationEmailRequest request)
        {
            var arguments = new object[] { customeremail,reservationid,request };
            return (Task) methodImpls["SendReservationEmail"](Client, arguments);
        }

        public virtual Task<ReservationConfirmationCollection> GetReservations(string customeremail,string playdatemin,string playdatemax,ExpandRequest options,string take,string skip,string sortby,string sortdirection,string channelid,string fields)
        {
            var arguments = new object[] { customeremail,playdatemin,playdatemax,options,take,skip,sortby,sortdirection,channelid,fields };
            return (Task<ReservationConfirmationCollection>) methodImpls["GetReservations"](Client, arguments);
        }

        public virtual Task<Facility[]> GetResidentFacilities(string customeremail)
        {
            var arguments = new object[] { customeremail };
            return (Task<Facility[]>) methodImpls["GetResidentFacilities"](Client, arguments);
        }

        public virtual Task AddResidentFacility(string customeremail,string facilityid)
        {
            var arguments = new object[] { customeremail,facilityid };
            return (Task) methodImpls["AddResidentFacility"](Client, arguments);
        }

        public virtual Task RemoveResidentGolfFacility(string customeremail,string facilityid)
        {
            var arguments = new object[] { customeremail,facilityid };
            return (Task) methodImpls["RemoveResidentGolfFacility"](Client, arguments);
        }

        public virtual Task<Boolean> IsAlive()
        {
            var arguments = new object[] {  };
            return (Task<Boolean>) methodImpls["IsAlive"](Client, arguments);
        }

        public virtual Task<string> SecureEcho(string input)
        {
            var arguments = new object[] { input };
            return (Task<string>) methodImpls["SecureEcho"](Client, arguments);
        }

        public virtual Task<Country[]> GetCountries(string channelid)
        {
            var arguments = new object[] { channelid };
            return (Task<Country[]>) methodImpls["GetCountries"](Client, arguments);
        }

        public virtual Task<Country[]> GetAllCountries()
        {
            var arguments = new object[] {  };
            return (Task<Country[]>) methodImpls["GetAllCountries"](Client, arguments);
        }

        public virtual Task<StateProvince[]> GetStatesByCountryCode(string countrycode)
        {
            var arguments = new object[] { countrycode };
            return (Task<StateProvince[]>) methodImpls["GetStatesByCountryCode"](Client, arguments);
        }

        public virtual Task<StateProvince[]> GetStates(string channelid,string countrycode)
        {
            var arguments = new object[] { channelid,countrycode };
            return (Task<StateProvince[]>) methodImpls["GetStates"](Client, arguments);
        }

        public virtual Task<City[]> GetCities(string channelid,string countrycode,string stateprovincecode)
        {
            var arguments = new object[] { channelid,countrycode,stateprovincecode };
            return (Task<City[]>) methodImpls["GetCities"](Client, arguments);
        }

        public virtual Task<FacilityDetail[]> GetFacilitiesByChannel(string channelid,string skip,string take,ExpandRequest options)
        {
            var arguments = new object[] { channelid,skip,take,options };
            return (Task<FacilityDetail[]>) methodImpls["GetFacilitiesByChannel"](Client, arguments);
        }

        public virtual Task<FacilityDetail[]> GetFacilitiesByCity(string channelid,string countrycode,string stateprovincecode,string city,string tags,ExpandRequest options)
        {
            var arguments = new object[] { channelid,countrycode,stateprovincecode,city,tags,options };
            return (Task<FacilityDetail[]>) methodImpls["GetFacilitiesByCity"](Client, arguments);
        }

        public virtual Task<FacilityDetail> GetFacility(string channelid,string facilityid,ExpandRequest options)
        {
            var arguments = new object[] { channelid,facilityid,options };
            return (Task<FacilityDetail>) methodImpls["GetFacility"](Client, arguments);
        }

        public virtual Task<TeeTimeRate[]> RequestTeeTimeUpdates(string channelid,TeeTimeBatchLookupRequest request)
        {
            var arguments = new object[] { channelid,request };
            return (Task<TeeTimeRate[]>) methodImpls["RequestTeeTimeUpdates"](Client, arguments);
        }

        public virtual Task<TeeTimeCollection> GetTeeTimesByFacility(string channelid,string facilityid,string datemin,string datemax,string pricemin,string pricemax,string playercount,string ratetags,string timemin,string timemax,string holecount,ExpandRequest options,string take,string skip,string sortby,string sortdirection,string ratetype,string mode)
        {
            var arguments = new object[] { channelid,facilityid,datemin,datemax,pricemin,pricemax,playercount,ratetags,timemin,timemax,holecount,options,take,skip,sortby,sortdirection,ratetype,mode };
            return (Task<TeeTimeCollection>) methodImpls["GetTeeTimesByFacility"](Client, arguments);
        }

        public virtual Task<TeeTimeRateset[]> GetAdjacentTeeTimes(string channelid,string facilityid,string teetimerateid,string minplayercount,string take)
        {
            var arguments = new object[] { channelid,facilityid,teetimerateid,minplayercount,take };
            return (Task<TeeTimeRateset[]>) methodImpls["GetAdjacentTeeTimes"](Client, arguments);
        }

        public virtual Task<TopDealsResponse> GetTopDeals(string channelid,string take)
        {
            var arguments = new object[] { channelid,take };
            return (Task<TopDealsResponse>) methodImpls["GetTopDeals"](Client, arguments);
        }

        public virtual Task<FacilityRate[]> GetBestRates(string channelid,Single latitude,Single longitude,Int32 radius,string startdate,string enddate)
        {
            var arguments = new object[] { channelid,latitude,longitude,radius,startdate,enddate };
            return (Task<FacilityRate[]>) methodImpls["GetBestRates"](Client, arguments);
        }

        public virtual Task<TeeTimeInvoice> GetTeeTimeInvoice(string channelid,string facilityid,string teetimerateid,string playercount,string verify)
        {
            var arguments = new object[] { channelid,facilityid,teetimerateid,playercount,verify };
            return (Task<TeeTimeInvoice>) methodImpls["GetTeeTimeInvoice"](Client, arguments);
        }

        public virtual Task<Market[]> GetMarkets(string channelid)
        {
            var arguments = new object[] { channelid };
            return (Task<Market[]>) methodImpls["GetMarkets"](Client, arguments);
        }

        public virtual Task<Market> GetMarket(string channelid,string marketid)
        {
            var arguments = new object[] { channelid,marketid };
            return (Task<Market>) methodImpls["GetMarket"](Client, arguments);
        }

        public virtual Task<FacilityDetail[]> GetFacilitiesByMarket(string channelid,string marketid,string tags,ExpandRequest options)
        {
            var arguments = new object[] { channelid,marketid,tags,options };
            return (Task<FacilityDetail[]>) methodImpls["GetFacilitiesByMarket"](Client, arguments);
        }

        public virtual Task<Market[]> GetMarketsByState(string channelid,string countrycode,string stateprovincecode)
        {
            var arguments = new object[] { channelid,countrycode,stateprovincecode };
            return (Task<Market[]>) methodImpls["GetMarketsByState"](Client, arguments);
        }

        public virtual Task<String[]> GetMessages(string channelid)
        {
            var arguments = new object[] { channelid };
            return (Task<String[]>) methodImpls["GetMessages"](Client, arguments);
        }

        public virtual Task<GeographicInformation> GetGeographicInformationByPostalCode(string postalcode)
        {
            var arguments = new object[] { postalcode };
            return (Task<GeographicInformation>) methodImpls["GetGeographicInformationByPostalCode"](Client, arguments);
        }

        public virtual Task<GeographicInformation> GetGeographicInformationByIPAddress(string ipaddress)
        {
            var arguments = new object[] { ipaddress };
            return (Task<GeographicInformation>) methodImpls["GetGeographicInformationByIPAddress"](Client, arguments);
        }

        public virtual Task<ReviewCollection> GetRatingsByFacility(string channelid,string facilityid,string take,string skip,string sortby,string sortdirection)
        {
            var arguments = new object[] { channelid,facilityid,take,skip,sortby,sortdirection };
            return (Task<ReviewCollection>) methodImpls["GetRatingsByFacility"](Client, arguments);
        }

        public virtual Task<FacilityDetail[]> GetFacilitiesByNameCityContainsQuery(string channelid,string query,Boolean nameOnly)
        {
            var arguments = new object[] { channelid,query,nameOnly };
            return (Task<FacilityDetail[]>) methodImpls["GetFacilitiesByNameCityContainsQuery"](Client, arguments);
        }

        public virtual Task<FacilityDetail[]> GetFeaturedFacilities(string channelid)
        {
            var arguments = new object[] { channelid };
            return (Task<FacilityDetail[]>) methodImpls["GetFeaturedFacilities"](Client, arguments);
        }

        public virtual Task<CustomerSubscriptionList[]> GetSubscriptionLists()
        {
            var arguments = new object[] {  };
            return (Task<CustomerSubscriptionList[]>) methodImpls["GetSubscriptionLists"](Client, arguments);
        }

        public virtual Task<Subscription[]> GetSubscriptionsByZipCode(string zipcode)
        {
            var arguments = new object[] { zipcode };
            return (Task<Subscription[]>) methodImpls["GetSubscriptionsByZipCode"](Client, arguments);
        }

        public virtual Task<CustomerSubscriptionStatus> GetSubscriptionStatus(string customeremail,string subscriptionlistid)
        {
            var arguments = new object[] { customeremail,subscriptionlistid };
            return (Task<CustomerSubscriptionStatus>) methodImpls["GetSubscriptionStatus"](Client, arguments);
        }

        public virtual Task UpdateSubscriptionStatus(string customeremail,string subscriptionlistid,CustomerSubscriptionStatus status,string callbackUrl)
        {
            var arguments = new object[] { customeremail,subscriptionlistid,status,callbackUrl };
            return (Task) methodImpls["UpdateSubscriptionStatus"](Client, arguments);
        }

        public virtual Task SendForgotPasswordEmail(string customeremail)
        {
            var arguments = new object[] { customeremail };
            return (Task) methodImpls["SendForgotPasswordEmail"](Client, arguments);
        }

        public virtual Task SendForgotPasswordEmailByChannel(string customeremail,string channelid,SendForgotPasswordEmailRequest request)
        {
            var arguments = new object[] { customeremail,channelid,request };
            return (Task) methodImpls["SendForgotPasswordEmailByChannel"](Client, arguments);
        }

        public virtual Task<Boolean> ValidateForgotPasswordToken(ValidateTokenRequest request)
        {
            var arguments = new object[] { request };
            return (Task<Boolean>) methodImpls["ValidateForgotPasswordToken"](Client, arguments);
        }

        public virtual Task<Boolean> ResetPassword(ResetPasswordTokenRequest request)
        {
            var arguments = new object[] { request };
            return (Task<Boolean>) methodImpls["ResetPassword"](Client, arguments);
        }

        public virtual Task<string> GetAgreement(string agreementstatementid)
        {
            var arguments = new object[] { agreementstatementid };
            return (Task<string>) methodImpls["GetAgreement"](Client, arguments);
        }

        public virtual Task<String[][]> GetCoupons(string channelid)
        {
            var arguments = new object[] { channelid };
            return (Task<String[][]>) methodImpls["GetCoupons"](Client, arguments);
        }

        public virtual Task<ChannelSettings> GetChannelSettings(string channelid)
        {
            var arguments = new object[] { channelid };
            return (Task<ChannelSettings>) methodImpls["GetChannelSettings"](Client, arguments);
        }

        public virtual Task<FacilityDetail[]> GetFacilitiesByPostalCode(string channelid,string postalcode,Int32 proximity,string minplayercount,string tags,ExpandRequest options)
        {
            var arguments = new object[] { channelid,postalcode,proximity,minplayercount,tags,options };
            return (Task<FacilityDetail[]>) methodImpls["GetFacilitiesByPostalCode"](Client, arguments);
        }

        public virtual Task<FacilityDetail[]> GetFacilitiesByGeoLocation(string channelid,Single latitude,Single longitude,Int32 proximity,string playercount,string datemin,string datemax,string facilitytags,ExpandRequest options,string fields)
        {
            var arguments = new object[] { channelid,latitude,longitude,proximity,playercount,datemin,datemax,facilitytags,options,fields };
            return (Task<FacilityDetail[]>) methodImpls["GetFacilitiesByGeoLocation"](Client, arguments);
        }

        public virtual Task<TeeTimeCollection> GetTeeTimesByGeoLocation(string channelid,Single latitude,Single longitude,Int32 proximity,string pricemin,string pricemax,string playercount,string facilitytags,string ratetags,string datemin,string datemax,string timemin,string timemax,string holecount,ExpandRequest options,string take,string skip,string sortby,string sortdirection,string ratetype,string mode,string fields,string tradeonly)
        {
            var arguments = new object[] { channelid,latitude,longitude,proximity,pricemin,pricemax,playercount,facilitytags,ratetags,datemin,datemax,timemin,timemax,holecount,options,take,skip,sortby,sortdirection,ratetype,mode,fields,tradeonly };
            return (Task<TeeTimeCollection>) methodImpls["GetTeeTimesByGeoLocation"](Client, arguments);
        }

        public virtual Task<RateTag[]> GetRateTags()
        {
            var arguments = new object[] {  };
            return (Task<RateTag[]>) methodImpls["GetRateTags"](Client, arguments);
        }

        public virtual Task<RateTag> GetRateTag(string tagcode)
        {
            var arguments = new object[] { tagcode };
            return (Task<RateTag>) methodImpls["GetRateTag"](Client, arguments);
        }

        public virtual Task<WeatherForcast[]> GetWeather(string channelid,string countrycode,string postalcode)
        {
            var arguments = new object[] { channelid,countrycode,postalcode };
            return (Task<WeatherForcast[]>) methodImpls["GetWeather"](Client, arguments);
        }

        public virtual Task<UserInfo> GetCustomerUserInfoByGuid(string customerguid)
        {
            var arguments = new object[] { customerguid };
            return (Task<UserInfo>) methodImpls["GetCustomerUserInfoByGuid"](Client, arguments);
        }

        public virtual Task<UserInfo> GetCustomerUserInfoByEmail(string customeremail)
        {
            var arguments = new object[] { customeremail };
            return (Task<UserInfo>) methodImpls["GetCustomerUserInfoByEmail"](Client, arguments);
        }

        public virtual Task<UserInfo> GetCustomerUserInfoByUserName(string username)
        {
            var arguments = new object[] { username };
            return (Task<UserInfo>) methodImpls["GetCustomerUserInfoByUserName"](Client, arguments);
        }

        public virtual Task ChangeCustomerPassword(string customeremail,PasswordChangeRequest request)
        {
            var arguments = new object[] { customeremail,request };
            return (Task) methodImpls["ChangeCustomerPassword"](Client, arguments);
        }

        public virtual Task<string> GetBookingUri(string channelid,string facilityid,string teetimerateid,string playercount,string redirect)
        {
            var arguments = new object[] { channelid,facilityid,teetimerateid,playercount,redirect };
            return (Task<string>) methodImpls["GetBookingUri"](Client, arguments);
        }

        public virtual Task<TeeTimeCollection> GetTeeTimesByMarket(string channelid,Int32 marketid,string pricemin,string pricemax,string playercount,string facilitytags,string ratetags,string datemin,string datemax,string timemin,string timemax,string holecount,ExpandRequest options,string take,string skip,string sortby,string sortdirection,string ratetype,string mode)
        {
            var arguments = new object[] { channelid,marketid,pricemin,pricemax,playercount,facilitytags,ratetags,datemin,datemax,timemin,timemax,holecount,options,take,skip,sortby,sortdirection,ratetype,mode };
            return (Task<TeeTimeCollection>) methodImpls["GetTeeTimesByMarket"](Client, arguments);
        }

        public virtual Task<FacilitySummaryCollection> GetFacilitySummariesByGeolocation(string channelid,Single latitude,Single longitude,Int32 proximity,string pricemin,string pricemax,string playercount,string facilitytags,string ratetags,string datemin,string datemax,string timemin,string timemax,string holecount,string take,string skip,string sortby,string sortdirection,string ratetype,ExpandRequest options,string fields,string tradeonly)
        {
            var arguments = new object[] { channelid,latitude,longitude,proximity,pricemin,pricemax,playercount,facilitytags,ratetags,datemin,datemax,timemin,timemax,holecount,take,skip,sortby,sortdirection,ratetype,options,fields,tradeonly };
            return (Task<FacilitySummaryCollection>) methodImpls["GetFacilitySummariesByGeolocation"](Client, arguments);
        }

        public virtual Task SetIsEmailVerified(string customeremail,Boolean isemailverified)
        {
            var arguments = new object[] { customeremail,isemailverified };
            return (Task) methodImpls["SetIsEmailVerified"](Client, arguments);
        }

        public virtual Task<PurchaseStatus> AddPurchase(string channelid,string purchaseid,Purchase purchase)
        {
            var arguments = new object[] { channelid,purchaseid,purchase };
            return (Task<PurchaseStatus>) methodImpls["AddPurchase"](Client, arguments);
        }

        public virtual Task<Purchase> GetPurchase(string channelid,string purchaseid)
        {
            var arguments = new object[] { channelid,purchaseid };
            return (Task<Purchase>) methodImpls["GetPurchase"](Client, arguments);
        }

        public virtual Task<PurchaseStatus> GetPurchaseStatus(string channelid,string customeremail,string productid)
        {
            var arguments = new object[] { channelid,customeremail,productid };
            return (Task<PurchaseStatus>) methodImpls["GetPurchaseStatus"](Client, arguments);
        }

        public virtual Task<PromoCode> AddPromoCode(string customeremail,PromoCodeInfo promoCodeInfo)
        {
            var arguments = new object[] { customeremail,promoCodeInfo };
            return (Task<PromoCode>) methodImpls["AddPromoCode"](Client, arguments);
        }

        public virtual Task<Rewards> GetRewardsStatus(string customeremail)
        {
            var arguments = new object[] { customeremail };
            return (Task<Rewards>) methodImpls["GetRewardsStatus"](Client, arguments);
        }

        public virtual Task<PromoCodeCollection> GetPromoCodes(string customeremail)
        {
            var arguments = new object[] { customeremail };
            return (Task<PromoCodeCollection>) methodImpls["GetPromoCodes"](Client, arguments);
        }

        public virtual Task<AreaSearchResult> SearchAreas(string input,Int32 resultcount)
        {
            var arguments = new object[] { input,resultcount };
            return (Task<AreaSearchResult>) methodImpls["SearchAreas"](Client, arguments);
        }

        public virtual Task<FacilitySearchResult> SearchFacilities(string input,Int32 resultcount,string channelid,string tags,string includeTags,string fields)
        {
            var arguments = new object[] { input,resultcount,channelid,tags,includeTags,fields };
            return (Task<FacilitySearchResult>) methodImpls["SearchFacilities"](Client, arguments);
        }

        public virtual Task<CustomerEligibility> GetCustomerEligibility(string customeremail,string verificationtypes,string statusstartdate,string organizationname,string resubmit,string lookupcacheonly)
        {
            var arguments = new object[] { customeremail,verificationtypes,statusstartdate,organizationname,resubmit,lookupcacheonly };
            return (Task<CustomerEligibility>) methodImpls["GetCustomerEligibility"](Client, arguments);
        }

        public virtual Task<DocumentationReviewRequestResult> RequestEligibilityDocumentationReview(string customeremail,DocumentationReviewRequest reviewrequest)
        {
            var arguments = new object[] { customeremail,reviewrequest };
            return (Task<DocumentationReviewRequestResult>) methodImpls["RequestEligibilityDocumentationReview"](Client, arguments);
        }

    }
}

namespace GolfNow.Mobile.Api
{
    using RefitInternalGenerated;

    [Preserve]
    public partial class AutoGeneratedIGooglePlacesApi : IGooglePlacesApi
    {
        public HttpClient Client { get; protected set; }
        readonly Dictionary<string, Func<HttpClient, object[], object>> methodImpls;

        public AutoGeneratedIGooglePlacesApi(HttpClient client, IRequestBuilder requestBuilder)
        {
            methodImpls = requestBuilder.InterfaceHttpMethods.ToDictionary(k => k, v => requestBuilder.BuildRestResultFuncForMethod(v));
            Client = client;
        }

        public virtual Task<PlacesResponseObject> GetPlaceSuggestions(string key,string input)
        {
            var arguments = new object[] { key,input };
            return (Task<PlacesResponseObject>) methodImpls["GetPlaceSuggestions"](Client, arguments);
        }

        public virtual Task<DetailsResponseObject> GetPlaceSuggestionDetail(string key,string reference)
        {
            var arguments = new object[] { key,reference };
            return (Task<DetailsResponseObject>) methodImpls["GetPlaceSuggestionDetail"](Client, arguments);
        }

    }
}