﻿namespace DemoTLS
{
    public static class SessionService
    {
        public static string CurrentAlgorithm { get; set; }

        public static string GenerateSharedKeyWithPrivateKeyAndRandomSessionKey()
        {
            return "SHARED_SECRET";
        }
    }
}