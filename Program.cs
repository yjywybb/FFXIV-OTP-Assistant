using System;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;

namespace FFXIV_OTP_Assistant
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = string.Empty;
            if (args.Length != 0 && args[0].Length == 32)
            {
                key = Encoding.Default.GetString(Base32.ToBytes(args[0]));
            }
            else if (args.Length != 0 && args[0].Length > 32)
            {
                Regex regex = new Regex(@"[A-Za-z0-9\/\+]{20}");
                string key_origin = Encoding.Default.GetString(Base64Decoder.Decoder.GetDecoded(args[0]));
                Match match = regex.Match(key_origin);
                key = match.Groups[0].Value;
            }
            if (key == string.Empty)
            {
                MessageBox.Show("Invalid Key!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            long duration = 30;
            GoogleAuthenticator authenticator = new GoogleAuthenticator(duration, key);
            var code = authenticator.GenerateCode();
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://127.0.0.1:4646/ffxivlauncher/" + code);
            request.GetResponse();
        }
    }
}
