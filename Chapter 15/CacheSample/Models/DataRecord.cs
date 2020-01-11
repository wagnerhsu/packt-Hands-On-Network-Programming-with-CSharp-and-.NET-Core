using System.Collections.Generic;

namespace CacheSample.Models
{
    public class DataRecord
    {
        public int Id { get; set; }
        public string SimpleString { get; set; }
        public List<string> StringList { get; set; } = new List<string>();
    }
}