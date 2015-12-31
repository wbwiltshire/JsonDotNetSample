using System;
using System.Collections.Generic;
using System.Data.Objects;
using EFDatabaseFirst.Data.POCOEntities;
using EFDatabaseFirst.Data.POCOState;

namespace EFDatabaseFirst.Data.Model.Interfaces
{
    public interface IContext
    {
        ObjectContextOptions MyContextOptions { get; set; }
        IObjectSet<Boat> Boats { get; }
        IObjectSet<Direction> Directions { get; }
        IObjectSet<Location> Locations { get; }
        IObjectSet<Manufacturer> Manufacturers { get; }
        IObjectSet<SeaCondition> SeaConditions { get; }
        IObjectSet<CloudCondition> CloudConditions { get; }
        IObjectSet<Trip> Trips { get; }
        IObjectSet<TripLog> TripLogs { get; }
        IObjectSet<City> Cities { get; }
        IObjectSet<State> States { get; }
        IObjectSet<Country> Countries { get; }
        int Save();
        IEnumerable<T> ManagedEntities<T>();
        void ChangeState<T>(ObjectState state, T entity) where T : class;
        void Dispose();
    }
}
