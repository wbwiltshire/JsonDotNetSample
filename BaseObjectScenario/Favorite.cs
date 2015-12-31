using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace BaseObjectScenario
{
    public class Favorites
    {
        [JsonProperty("favorites")]
        //public IList<Favorite> Favs { get; set; }
        public int[] Favs { get; set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (int f in Favs)
            {
                sb.Append(String.Format("{0}|", f.ToString())).Append(Environment.NewLine);
            }
            return sb.ToString();
        }
    }
    public class Favorite
    {
        public int Id { get; set; }
        public override string ToString()
        {
            return String.Format("{0}", Id);
        }
    }
}
