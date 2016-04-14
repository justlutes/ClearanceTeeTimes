using System;
using System.Diagnostics;

namespace GolfNow.Mobile.Api
{
	public static class AsyncErrorHandler
	{
		public static void HandleException(Exception exception)
		{
			Debug.WriteLine(exception);
		}
	}
}

