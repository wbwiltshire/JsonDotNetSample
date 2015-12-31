using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Entity;

namespace EFDatabaseFirst.Data.POCOState
{
    public enum ObjectState
    {
        Unchanged, Added, Modified, Deleted
    }

    public static class StateHelpers
    {
        public static EntityState GetEquivalentEntityState(ObjectState state)
        {
            //this handy method comes from Rowan Miller on the EF team!
            switch (state)
            {
                case ObjectState.Added:
                    return EntityState.Added;
                case ObjectState.Modified:
                    return EntityState.Modified;
                case ObjectState.Deleted:
                    return EntityState.Deleted;
                default:
                    return EntityState.Unchanged;
            }
        }
    }
}
