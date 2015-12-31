using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace BaseObjectScenario
{
    public class JsonData<TEntity>
         where TEntity : class
    {
        [JsonProperty("data")]
        public IList<TEntity> data { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (TEntity l in data)
            {
                sb.Append(l.ToString()).Append(Environment.NewLine);
            }

            return sb.ToString();
        }
    }
}
