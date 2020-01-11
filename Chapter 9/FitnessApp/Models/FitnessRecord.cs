using System;

namespace FitnessApp.Models
{
    public class FitnessRecord
    {
        public string Title { get; set; }
        public string WorkoutType { get; set; }
        public string Comments { get; set; }
        public DateTime WorkoutDate { get; set; }
    }
}