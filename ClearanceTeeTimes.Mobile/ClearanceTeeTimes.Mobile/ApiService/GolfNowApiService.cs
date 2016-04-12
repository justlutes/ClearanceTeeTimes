using System;
using System.Net.Http;
using System.Threading.Tasks;
using Fusillade;
using GolfNow.Mobile;
using ModernHttpClient;
using Newtonsoft.Json;
using Refit;
using GolfNow.Mobile.Api;

namespace ClearanceTeeTimes.Mobile
{
	[Preserve (AllMembers = true)]

	public class GolfNowApiService
	{
		//public const string ApiBaseAddress = "https://rcapi.gnsvc.com/rest";
		//public const string ApiBaseAddress = "https://2-1-17.devapi.gnsvc.com/rest";
		public const string ApiBaseAddress = "https://2-1-17-sandbox.api.gnsvc.com/rest";
		//public const string ApiBaseAddress = "https://2-1-17.api.gnsvc.com/rest";
		private readonly Lazy<IMobileGolfNowApi> _background;
		private readonly Lazy<IMobileGolfNowApi> _speculative;
		private readonly Lazy<IMobileGolfNowApi> _userInitiated;

		public string ApiPassword;
		public string ApiUser;



		public GolfNowApiService (string userName, string passWord, string apiBaseAddress = null)
		{ApiUser = userName;
			ApiPassword = passWord;

			Func<HttpMessageHandler, IMobileGolfNowApi> createClient = messageHandler => {
				var client = new HttpClient (messageHandler) {
					BaseAddress = new Uri (apiBaseAddress)
				};

				client.DefaultRequestHeaders.Add ("UserName", userName);
				client.DefaultRequestHeaders.Add ("Password", passWord);


				return RestService.For<IMobileGolfNowApi> (client, new RefitSettings()
					{

						JsonSerializerSettings = new Newtonsoft.Json.JsonSerializerSettings()
						{
							Converters = {new SavedPaymentConverter()},
							TypeNameHandling = TypeNameHandling.Objects
						},
					});
			};

			_background = new Lazy<IMobileGolfNowApi> (() => createClient (
				new RateLimitedHttpMessageHandler (new GolfNowApiAuthenticationHandler (), Priority.Background)));

			_userInitiated = new Lazy<IMobileGolfNowApi> (() => createClient (
				new RateLimitedHttpMessageHandler (new GolfNowApiAuthenticationHandler (), Priority.UserInitiated)));

			_speculative = new Lazy<IMobileGolfNowApi> (() => createClient (
				new RateLimitedHttpMessageHandler (new GolfNowApiAuthenticationHandler (), Priority.Speculative)));

			//TODO: Xamarin : add a check for connection before making the requests.
			Task.Run (async () => await InitiateClients ());
		}

		private async Task InitiateClients ()
		{
			try {
				await _background.Value.SecureEcho ("I");
				await _userInitiated.Value.SecureEcho ("I");
				await _speculative.Value.SecureEcho ("I");
			} catch (Exception ex) {

				ExceptionService.PublishEx (ex);

			}


		}


		[Preserve]
		public IMobileGolfNowApi Background {
			get { return _background.Value; }
		}

		[Preserve]
		public IMobileGolfNowApi UserInitiated {
			get { return _userInitiated.Value; }
		}

		[Preserve]
		public IMobileGolfNowApi Speculative {
			get { return _speculative.Value; }
		}


		public IMobileGolfNowApi GetPriorityApi (Priority priority)
		{
			IMobileGolfNowApi api;
			switch (priority) {
			case Priority.Background:
				api = this.Background;
				break;
			case Priority.UserInitiated:
				api = this.UserInitiated;
				break;
			case Priority.Speculative:
				api = this.Speculative;
				break;
			default:
				api = this.UserInitiated;
				break;
			}

			return api;

		}
	}
}

