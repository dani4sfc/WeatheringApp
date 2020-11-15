using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Utils
{
    public class ETL
    {

        const double KELVINREF = -273.15;

        public static float ParseTimeZone(float data)
        {

            float result = 0;

            result = data / 3600;

            return result;

        }

        public static double ParseMainFloat(double value)
        {
            double result = 0;

            result = value + KELVINREF;

            return result;
        }

        public static double ParseWind(double value)
        {
            double result = value * 3.6;

            return result;
        }

        public static int ParseClouds(int value)
        {
            int result = 0;

            return result = value / 100;

        }

        public static string ParseSys(int value)
        {
            string st = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(value).ToShortDateString();
            return st;
        }
    }

}