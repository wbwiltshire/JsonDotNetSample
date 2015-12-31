using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using Newtonsoft.Json;
using EFDatabaseFirst.Data.Model;
using EFDatabaseFirst.Data.Model.Interfaces;
using EFDatabaseFirst.Data.POCOEntities;

namespace EFDatabaseFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            string objectString = String.Empty;
            Console.WriteLine("Running EF Database First Scenario");
            Console.WriteLine();
            var locations = InitializeScenario();
            objectString = JsonConvert.SerializeObject(locations, Formatting.Indented , new JsonSerializerSettings {
                PreserveReferencesHandling = PreserveReferencesHandling.None,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });
            Console.WriteLine(String.Format("ObjectString {0}", objectString));
            Console.WriteLine("Press <enter> key to continue...");
            Console.ReadLine();
        }

        #region Initialize
        private static Location InitializeScenario()
        {
            JsonTestContext context = new JsonTestContext();
            Location location = context.Locations.Include("City").Include("City.State").FirstOrDefault(l => l.Id == 3);
            return location;
        }
        #endregion

    }
}
