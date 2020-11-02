using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class ApiService
    {
        public static async Task ConnectToAPI()
        {
            WeatherRoot weather = new WeatherRoot();

            string requestBase = "api.openweathermap.org/data/2.5/weather?q=";

            string cityParam = "Seville";

            string apiId = "&appid=8a0af1c275d86c2fa5b63f23bec8a6bb";

            string apiRequest = "http://"+requestBase + cityParam + apiId;

            HttpClient client = new HttpClient();

            var request = new HttpRequestMessage(HttpMethod.Get, apiRequest);

            HttpResponseMessage response = new HttpResponseMessage();

            try
            {
                response = await client.SendAsync(request);

            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine("Error: "+ex.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);

            }


            if (response.IsSuccessStatusCode)
            {
                using (var responseStream = response.Content.ReadAsStringAsync()) {

                    Console.WriteLine("200 returned from API \n");

                    //Use json library to deserialize / read the content as string

                    string data = responseStream.Result;

                    //string json = JsonConvert.SerializeObject(Weather);

                    try
                    {
                        WeatherRoot wObject = JsonConvert.DeserializeObject<WeatherRoot>(data);

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error: "+e.Message);
                    }

                    //JsonConvert.DeserializeObject(Weather);


                }
            }
         
        }
    }
}
