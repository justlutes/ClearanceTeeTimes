using System;
using System.Text;
using PCLCrypto;
using System.Security.Cryptography;

namespace GolfNow.Mobile.API.Utilities
{
	public class Authorization
	{
        public static string GetAuthorizationHeader(string username, string password, int timestamp, string secret)
        {
            string toHash = String.Format("{0}" + "{1}{2}", username, Convert.ToBase64String(HashSha1(password)), timestamp);
            return Convert.ToBase64String(HashHmac256(Encoding.UTF8.GetBytes(toHash), Encoding.UTF8.GetBytes(secret)));
        }

        private static byte[] HashHmac256(byte[] data, byte[] key)
        {
            using (var hmacAlgorithm = new HMACSHA256(key))
            {
               return hmacAlgorithm.ComputeHash(data);
                
            }
        }

        private static byte[] HashSha1(string s)
        {

            var hasher =  WinRTCrypto.HashAlgorithmProvider.OpenAlgorithm(HashAlgorithm.Sha1);
            byte[] inputBytes = Encoding.UTF8.GetBytes(s);
            byte[] hash = hasher.HashData(inputBytes);       
            //SHA1 sha1 = SHA1.Create();
            //byte[] octets = Encoding.UTF8.GetBytes(s);
            //byte[] hash = sha1.ComputeHash(octets);

            return hash;
        }
	}
}
