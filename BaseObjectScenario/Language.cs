using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace BaseObjectScenario
{
    public class Language
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("abbreviation")]
        public string Abbreviation { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("englishname")]
        public string EnglishName { get; set; }

        public override string ToString()
        {
            return String.Format("{0}|{1}|{2}|{3}", Id, Abbreviation, Name, EnglishName);
        }
    }
}
