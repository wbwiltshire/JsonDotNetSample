using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace EFCodeFirstScenario
{
    public class JsonTestContext : DbContext
    {
        #region DbSet
        //Note: If you are going to use the DbSet, CodeFirst, and and Sql Server CE THEN you need to INCLUDE the JsonTestInitiazer.cs file.
        public DbSet<Location> Locations { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<State> States { get; set; }

        public JsonTestContext()
        {

            Database.SetInitializer<JsonTestContext>(new JsonTestInitializer());
        }
        #endregion
    }
}
