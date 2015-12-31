using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace ObjectOnlyScenario
{
    class Program
    {
        static void Main(string[] args)
        {
            string objectString = String.Empty;
            Console.WriteLine("Running Object Only Scenario");
            Console.WriteLine();

            var locations = Initialize();
            objectString = JsonConvert.SerializeObject(locations, Formatting.Indented, new JsonSerializerSettings
            {
                PreserveReferencesHandling = PreserveReferencesHandling.None,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });
            Console.WriteLine(String.Format("ObjectString : {0}", objectString));
            Console.WriteLine("Press <enter> key to continue...");
            Console.ReadLine();
        }

        #region Initalize
        private static IList<Location> Initialize()
        {
            ICollection<State> states = new Collection<State>() {
                new State() { Id = 1, Name = "FL", Cities = new Collection<City>(), ObjectState = 0 },
                new State() { Id = 2, Name = "GA", Cities = new Collection<City>(), ObjectState = 0 }
            }; 
            ICollection<City> cities = new Collection<City>() {
                new City() { Id = 1, StateId = 1, Name = "Tampa", State = states.FirstOrDefault(s => s.Id == 1), Locations = new Collection<Location>(), ObjectState = 0 },
                new City() { Id = 2, StateId = 2, Name = "Atlanta", State = states.FirstOrDefault(s => s.Id == 2), Locations = new Collection<Location>(), ObjectState = 0 }
            };

            Location location1 = new Location()
            {
                Id = 1,
                Name = "Elm Street",
                CityId = 1,
                City = cities.FirstOrDefault( c => c.Id == 1)
            };
            Location location2 = new Location()
            {
                Id = 2,
                Name = "First Street",
                CityId = 2,
                City = cities.FirstOrDefault(c => c.Id == 2)
            }; 

            states.FirstOrDefault(s => s.Id == 1).Cities.Add(cities.FirstOrDefault(c => c.Id == 1));
            states.FirstOrDefault(s => s.Id == 2).Cities.Add(cities.FirstOrDefault(c => c.Id == 2));
            cities.FirstOrDefault(c => c.Id == 1).Locations.Add(location1);
            cities.FirstOrDefault(c => c.Id == 2).Locations.Add(location2);

            IList<Location> locations = new List<Location>();
            locations.Add(location1);
            locations.Add(location2);
            return locations;
        }
        #endregion
    }
}
