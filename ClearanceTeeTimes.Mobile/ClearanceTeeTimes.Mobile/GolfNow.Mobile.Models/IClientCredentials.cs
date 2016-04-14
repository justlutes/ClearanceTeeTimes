using System;

namespace GolfNow.Mobile.Models
{
    /// <summary>
    /// Interface used to represent the credentials for a client login.
    /// </summary>
    // TODO: I think we want to rename this to IClientRequestConfiguration.  It is becomming more than just credentials.
    public interface IClientCredentials
    {
        /// <summary>
        /// Gets the user name of the client.
        /// </summary>
        string UserName
        {
            get;
        }

        /// <summary>
        /// Gets the password for the client.
        /// </summary>
        string Password
        {
            get;
        }

		/// <summary>
		/// Gets the authorization header for the client
		/// </summary>
		string Authorization
		{
			get;
		}

		/// <summary>
		/// Gets the timestamp header for the client
		/// </summary>
		int Timestamp
		{
			get;
		}

        /// <summary>
        /// A session id that identifes a user's application session.  The definition of a user's application session may vary 
        /// for each application, but a general rule of thumb is that the session id should reset after 15 minutes of user inactivity.
        /// </summary>
        Guid? SessionId
        {
            get;
        }

        /// <summary>
        /// The name of the application making the request
        /// </summary>
        string ApplicationName
        {
            get;
        }

        /// <summary>
        /// A string that defines an application agent.  This is very loosly defined for now, but use IOS, Android, HTTP_USER_AGENT
        /// </summary>
        string UserAgent
        {
            get;
        }
    }
}
