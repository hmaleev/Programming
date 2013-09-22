using System;
using System.Linq;
using System.Net;

namespace PhoneInformation.WebClientProject.Models
{
    class WebClientRequester
    {
        public static string Get(string resourceUrl)
        {
            var webClient = new WebClient();
            string result= webClient.DownloadString(resourceUrl);
            return result;
        }
    }
}
