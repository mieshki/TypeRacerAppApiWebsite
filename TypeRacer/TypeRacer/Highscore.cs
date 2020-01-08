using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeRacer
{
    public partial class HighscoresParser { public static List<Highscore> FromJson(string json) => JsonConvert.DeserializeObject<List<Highscore>>(json); }
    public class Highscore
    {

        [JsonProperty("Player")]
        public string Player { get; set; }
        [JsonProperty("WordsPerMinute")]
        public int WordsPerMinute { get; set; }
        [JsonProperty("TimeInSeconds")]
        public int TimeInSeconds { get; set; }
        [JsonProperty("Map")]
        public string Map { get; set; }
    }

    public class Highscores
    {
        public List<Highscore> allHighscores { get; set; }
    }
}
