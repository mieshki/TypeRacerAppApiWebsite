using System;
using System.ComponentModel.DataAnnotations;

namespace TypeRacerWebPageAndAPI.Models
{
    public class HighscoreModel
    {
        public int ID { get; set; }
        public string Player { get; set; }
        public int WordsPerMinute { get; set; }
        public int TimeInSeconds { get; set; }
        public string Map { get; set; }
    }
}