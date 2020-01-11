using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace DNSSimulation.Data
{
    public static class Hosts
    {
        public static IDictionary<string, IEnumerable<string>> Map;

        static Hosts()
        {
            try
            {
                using (var sr = new StreamReader("hosts.json"))
                {
                    var json = sr.ReadToEnd();
                    Map = JsonConvert.DeserializeObject<IDictionary<string, IEnumerable<string>>>(json);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}