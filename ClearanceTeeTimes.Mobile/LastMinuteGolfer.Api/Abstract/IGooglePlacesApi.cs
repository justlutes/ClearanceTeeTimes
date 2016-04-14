using System;
using Refit;
using GolfNow.Mobile.Models;
using System.Threading.Tasks;

namespace GolfNow.Mobile.Api
{
	[Headers ("Accept: application/json")]
	[Preserve (AllMembers = true)]
	public interface IGooglePlacesApi
	{
		/// <summary>
		///Returns a list of valid locations.
		/// </summary>

		[Get ("/autocomplete/json?sensor=false&key={key}&input={input}")]
		Task<PlacesResponseObject> GetPlaceSuggestions (string key, string input);



		/// <summary>
		///Returns the details of the locations searched for
		/// </summary>

		[Get ("/details/json?sensor=false&key={key}&reference={reference}")]
		Task<DetailsResponseObject> GetPlaceSuggestionDetail (string key, string reference);
		
	}
}

