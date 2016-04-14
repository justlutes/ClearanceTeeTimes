using System;
using System.Reactive.PlatformServices;
using System.Diagnostics;
using System.Threading.Tasks;

namespace GolfNow.Mobile.Business
{
	public static class ExceptionService
	{

		public static async Task PublishEx (Exception ex)
		{
			Task.Run (async () => Debug.WriteLine (ex.Message));
		}
	}
}

