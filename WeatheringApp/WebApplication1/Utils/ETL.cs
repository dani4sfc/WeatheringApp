using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Utils
{
    public class ETL
    {

        const double KELVINREF = -273.15;

        static async Task<float> ParseTimeZone(float data)
        {

            float result = 0;

            result = data / 3600;

            return result;

        }

        static async Task<double> ParseMainFloat(double value)
        {
            double result = 0;

            result = value + KELVINREF;

            return result;
        }

        static async Task<double> ParseWind(double value)
        {
            double result = value * 3.6;

            return result;
        }

        static async Task<double> ParseClouds(int id)
        {
            float test = 0;

            return test = id / 100;

        }

        static async Task<string> ParseSys(int value)
        {
            return new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(value).ToShortDateString();
        }
    }

}