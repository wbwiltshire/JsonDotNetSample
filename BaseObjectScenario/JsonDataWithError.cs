using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace BaseObjectScenario
{
    public class JsonDataWithError<TEntity>
        where TEntity : class
    {
        [JsonProperty("errors")]
        public string errors { get; set; }
        [JsonProperty("data")]
        public TEntity data { get; set; }

        public override string ToString()
        {
            return data.ToString();
        }
    }
}
