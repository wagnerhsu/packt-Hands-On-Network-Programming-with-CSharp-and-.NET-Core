﻿namespace DataAccessDemo.Services
{
    public static class Latency
    {
        private static int initialLatency = 1;
        private static int counter = 1;

        public static int GetLatency()
        {
            //milliseconds of latency. increase by .5 second per request
            return counter++ * 500;
        }

        public static void ResetLatency()
        {
            counter = initialLatency;
        }
    }
}