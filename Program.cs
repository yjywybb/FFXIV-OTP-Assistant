using System;
using System.Net;
using System.Text;

namespace FFXIV_OTP_Assistant
{
    class Program
    {
        static void Main(string[] args)
        {
            long duration = 30;
            string key = Encoding.Default.GetString(Base32.ToBytes(args[0]));
            GoogleAuthenticator authenticator = new GoogleAuthenticator(duration, key);
            var code = authenticator.GenerateCode();
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://127.0.0.1:4646/ffxivlauncher/" + code);
            request.GetResponse();
        }
    }
}
