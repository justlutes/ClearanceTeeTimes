using Xamarin.Forms;
using XamarinNativeFacebook;

namespace ClearanceTeeTimes.Mobile
{

		// Get your own App ID at developers.facebook.com/apps
	const string FacebookAppId = "511621399017656";

	// You must get this token authorizing by either using Facebook App or a WebView.
	// Please review included samples.
	string userToken;

	void PostToMyWall ()
	{
		FacebookClient fb = new FacebookClient (userToken);
		string myMessage = "Hello from Xamarin";

		fb.PostTaskAsync ("me/feed", new { message = myMessage }).ContinueWith (t => {
			if (!t.IsFaulted) {
				string message = "Great, your message has been posted to you wall!";
				Console.WriteLine (message);
			}
		});
	}

	void GetMyInfo ()
	{
		// This uses Facebook Graph API
		// See https://developers.facebook.com/docs/reference/api/ for more information.
		FacebookClient fb = new FacebookClient (userToken);

		fb.GetTaskAsync ("me").ContinueWith (t => {
			if (!t.IsFaulted) {
				var result = (IDictionary<string, object>)t.Result;
				var result = (IDictionary<string, object>)t.Result;
				string myDetails = string.Format ("Your name is: {0} {1} and your Facebook profile Url is: {3}", 
					(string)result["first_name"], (string)result["last_name"], 
					(string)result["link"]);
				Console.WriteLine (myDetails);
			}
		});
	}

	void PrintFriendsNames ()
	{
		// This uses Facebook Query Language
		// See https://developers.facebook.com/docs/technical-guides/fql/ for more information.
		var query = string.Format("SELECT uid,name,pic_square FROM user WHERE uid IN (SELECT uid2 FROM friend WHERE uid1={0}) ORDER BY name ASC", "me()");
		FacebookClient fb = new FacebookClient (userToken);

		fb.GetTaskAsync ("fql", new { q = query }).ContinueWith (t => {
			if (!t.IsFaulted) {
				var result = (IDictionary<string, object>)t.Result;
				var data = (IList<object>)result["data"];
				var count = data.Count;
				var message = string.Format ("You have {0} friends", count);
				Console.WriteLine (message);

				foreach (IDictionary<string, object> friend in data)
					Console.WriteLine ((string) friend["name"]);
			}
		});
	}
}