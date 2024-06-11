using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN371Project
{
    internal class SmsAPI
    {
        private static readonly string ApiBaseUrl = "https://qy68gm.api.infobip.com";
        private static readonly string ApiKey = "bf3356934c12f323ca25dfa78f0a1b09-b4773e30-d591-418d-bb4b-aa93b65588e4"; // Replace with your actual API key
        private static readonly string SenderNumber = "1AD64938DE25A3818114CD5E15DB817E";
        private static readonly string RecipientNumber = "27686944190";

        public async static Task<bool> SendSMSAsync(string message)
        {
            var client = new RestSharp.RestClient(ApiBaseUrl);
            var request = new RestRequest("/sms/1/text/single", Method.Post);
            request.AddHeader("Authorization", "App " + ApiKey);
            request.AddHeader("Content-Type", "application/json");

            var body = new
            {
                from = SenderNumber,
                to = RecipientNumber,
                text = message
            };

            request.AddJsonBody(body);

            var response = await client.ExecuteAsync(request);

            return response.IsSuccessful;
        }
    }
}
