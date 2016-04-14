using System;
using System.Diagnostics;

namespace GolfNow.Mobile.Business
{
	public static class AsyncErrorHandler
	{
		public static void HandleException (Exception exception)
		{
			Debug.WriteLine (exception.Message);
		}
	}
}
