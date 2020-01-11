using System.Collections.Generic;

namespace DataSimulation.Models
{
    public class OutputRecord
    {
        public int Id { get; set; }
        public string SimpleString { get; set; }
        public List<string> StringList { get; set; } = new List<string>();
    }
}