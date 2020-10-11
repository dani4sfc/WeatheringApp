using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace WebApplication1.Services
{
    public class ApiService
    {

        static async Task ConnectToAPI()
        {
            string apiKey = "8a0af1c275d86c2fa5b63f23bec8a6bb";

            string apiRequest = "api.openweathermap.org/data/2.5/weather?q=London&appid={8a0af1c275d86c2fa5b63f23bec8a6bb}";

            HttpClient client = new HttpClient();

            var request = new HttpRequestMessage(HttpMethod.Get, apiRequest);

            var response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                using (var responseStream = response.Content.ReadAsStringAsync()) {

                    //Use json library to deserialize / read the content as string

                    string data = responseStream.Result.ToString();
                    
                }
            }
         
        }
    }
}
