using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace EFCodeFirstScenario
{
    class Program
    {
        static void Main(string[] args)
        {
            string objectString = String.Empty;
            Console.WriteLine("Running EF Code FirstScenario.");
            Console.WriteLine();
            var locations = Initialize();
            objectString = JsonConvert.SerializeObject(locations, Formatting.Indented , new JsonSerializerSettings {
                PreserveReferencesHandling = PreserveReferencesHandling.None,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });

            Console.WriteLine(String.Format("ObjectString {0}", objectString));
            Console.WriteLine("Press <enter> key to continue...");
            Console.ReadLine();
        }

        #region Initialize
        private static Location Initialize()
        {
            JsonTestContext context = new JsonTestContext();
            Location location =  context.Locations.Include("City").Include("City.State").FirstOrDefault( l => l.Id == 3);
            return location;
        }
        #endregion
    }
}
