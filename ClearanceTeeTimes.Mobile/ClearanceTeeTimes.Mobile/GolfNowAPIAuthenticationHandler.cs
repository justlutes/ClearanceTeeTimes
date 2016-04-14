using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ModernHttpClient;



using GolfNow.Mobile.Business;


namespace GolfNow.Mobile.Business
{
    
    public class GolfNowApiAuthenticationHandler : NativeMessageHandler
    {
        
    
        private string customerToken;

        public GolfNowApiAuthenticationHandler()
        {			
    
        }

    

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
			
            // Check if request contains CustomerToken header
//			var TokenHeader = request.Headers.Where (h => h.Key == "CustomerToken");
//			var enumerable = TokenHeader.ToArray ();
//			if (enumerable.Any ()) {
//				
//				if (!enumerable.First ().Value.Equals (customerToken)) {
//					if (request.Headers.Remove ("CustomerToken")) {
//
//						request.Headers.TryAddWithoutValidation ("CustomerToken", customerToken);
//					}
//				}
//
//			}
            string token = string.Empty;
            if (!string.IsNullOrEmpty(customerToken))
            {
                token = customerToken.Replace(@"""", "");
            }

            request.Headers.Remove("CustomerToken");
            request.Headers.TryAddWithoutValidation("CustomerToken", token);
            var results = await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
            return results;
        }


    }
}

