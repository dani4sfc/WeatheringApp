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

        static async Task<float> ParseClouds(int id)
        {
            float test = 0;

            if (id == 1)
            {

            }
            else if (id == 2)
            {

            }

            return test;
        }

        static async Task<int> ParseSys(int id)
        {
            int test = 0;

            if (id == 1)
            {

            }
            else if (id == 2)
            {

            }

            return test;
        }
    }


}
