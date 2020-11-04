using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Utils
{
    public class ETL
    {

        static async Task<float> ParseTimeZone(float data)
        {

            float result = 0;

            result = data / 3600;

            return result;

        }

        static async Task<string> ParseWeather(int id)
        {
            string test = "";

            if (id == 1)
            {

            }
            else if (id == 2)
            {

            }

            return test;
        }

        static async Task<float> ParseMain(int id)
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

        static async Task<float> ParseWind(int id)
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

        static async Task<double> ParseSys(int id)
        {
            double test = 0;

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
