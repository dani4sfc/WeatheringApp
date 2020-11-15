using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Utils;

namespace WebApplication1.Services
{
    public class ETLService: ApiService
    {
        //WeatherRoot Weather = await GetData();

        public static async Task<WeatherRoot> GetData()
        {
            WeatherRoot weather = await ExtractData();

            weather.clouds.clouds = ETL.ParseClouds(weather.clouds.clouds);
            weather.timeZone = ETL.ParseTimeZone(weather.timeZone);
            weather.main.feelsLike = ETL.ParseMainFloat(weather.main.feelsLike);
            weather.main.tempMax = ETL.ParseMainFloat(weather.main.tempMax);
            weather.main.tempMin = ETL.ParseMainFloat(weather.main.tempMin);
            //weather.sys.sunrise = ETL.ParseSys(weather.sys.sunrise);
            //weather.sys.sunset = ETL.ParseSys(weather.sys.sunset);
            weather.wind.deg = ETL.ParseWind(weather.wind.deg);


            return weather;
        }
    }
}
