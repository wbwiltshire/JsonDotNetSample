using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Collections.ObjectModel;

namespace EFCodeFirstScenario
{
    class JsonTestInitializer : DropCreateDatabaseIfModelChanges<JsonTestContext>
    {
        protected override void Seed(JsonTestContext context)
        {
            ICollection<State> states = new Collection<State>() {
                new State() { Name = "FL", Cities = new Collection<City>(), ObjectState = 0 },
                new State() { Name = "GA", Cities = new Collection<City>(), ObjectState = 0 }
                };


            ICollection<City> cities = new Collection<City>() {
                new City() { StateId = 1, Name = "Tampa", State = states.FirstOrDefault(s => s.Id == 1), Locations = new Collection<Location>(), ObjectState = 0 },
                new City() { StateId = 2, Name = "Atlanta", State = states.FirstOrDefault(s => s.Id == 2), Locations = new Collection<Location>(), ObjectState = 0 }
            };

            Location location1 = new Location()
            {
                Name = "Elm Street",
                CityId = 1,
                City = cities.FirstOrDefault(c => c.Id == 1)
            };
            Location location2 = new Location()
            {
                Name = "First Street",
                CityId = 2,
                City = cities.FirstOrDefault(c => c.Id == 2)
            }; 

            states.FirstOrDefault().Cities.Add(cities.FirstOrDefault());
            states.LastOrDefault().Cities.Add(cities.LastOrDefault());
            foreach (State s in states)
                context.States.Add(s);
            context.SaveChanges();
            cities.FirstOrDefault().Locations.Add(location1);
            cities.LastOrDefault().Locations.Add(location2);
            foreach (City c in cities)
                context.Cities.Add(c);
            context.SaveChanges();

            context.Locations.Add(location1);
            context.Locations.Add(location2);
            context.SaveChanges();
        }
    }
}
