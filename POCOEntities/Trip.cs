//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using EFDatabaseFirst.Data.POCOState;

namespace EFDatabaseFirst.Data.POCOEntities
{
    [MetadataType(typeof(TripMetaData))]
    public partial class Trip : StateObject
    {
        #region Primitive Properties
    
    	public int Id
    	{
    		get;
    		set;
    	}
    
    	public string Name
    	{
    		get;
    		set;
    	}
    
    	public int BoatId
    	{
    		get { return _boatId; }
    		set
    		{
    			if (_boatId != value)
    			{
    				if (Boat != null && Boat.Id != value)
    				{
    					Boat = null;
    				}
    				_boatId = value;
    			}
    		}
    	}
    	private int _boatId;
    
    	public int DepartureLocId
    	{
    		get { return _departureLocId; }
    		set
    		{
    			if (_departureLocId != value)
    			{
    				if (Location != null && Location.Id != value)
    				{
    					Location = null;
    				}
    				_departureLocId = value;
    			}
    		}
    	}
    	private int _departureLocId;
    
    	public System.DateTime DepartureDt
    	{
    		get;
    		set;
    	}
    
    	public int DestinationLocId
    	{
    		get { return _destinationLocId; }
    		set
    		{
    			if (_destinationLocId != value)
    			{
    				if (Location1 != null && Location1.Id != value)
    				{
    					Location1 = null;
    				}
    				_destinationLocId = value;
    			}
    		}
    	}
    	private int _destinationLocId;
    
    	public System.DateTime ArrivalDt
    	{
    		get;
    		set;
    	}
    
    	public bool Active
    	{
    		get;
    		set;
    	}
    
    	public System.DateTime ModifiedDt
    	{
    		get;
    		set;
    	}
    
    	public System.DateTime CreateDt
    	{
    		get;
    		set;
    	}

        #endregion
        #region Navigation Properties
    
    	public Boat Boat
    	{
    		get { return _boat; }
    		set
    		{
    			if (!ReferenceEquals(_boat, value))
    			{
    				var previousValue = _boat;
    				_boat = value;
    				FixupBoat(previousValue);
    			}
    		}
    	}
    	private Boat _boat;
    
    	public Location Location
    	{
    		get { return _location; }
    		set
    		{
    			if (!ReferenceEquals(_location, value))
    			{
    				var previousValue = _location;
    				_location = value;
    				FixupLocation(previousValue);
    			}
    		}
    	}
    	private Location _location;
    
    	public Location Location1
    	{
    		get { return _location1; }
    		set
    		{
    			if (!ReferenceEquals(_location1, value))
    			{
    				var previousValue = _location1;
    				_location1 = value;
    				FixupLocation1(previousValue);
    			}
    		}
    	}
    	private Location _location1;
    
    	public ICollection<TripLog> TripLogs
    	{
    		get
    		{
    			if (_tripLogs == null)
    			{
    				var newCollection = new FixupCollection<TripLog>();
    				newCollection.CollectionChanged += FixupTripLogs;
    				_tripLogs = newCollection;
    			}
    			return _tripLogs;
    		}
    		set
    		{
    			if (!ReferenceEquals(_tripLogs, value))
    			{
    				var previousValue = _tripLogs as FixupCollection<TripLog>;
    				if (previousValue != null)
    				{
    					previousValue.CollectionChanged -= FixupTripLogs;
    				}
    				_tripLogs = value;
    				var newValue = value as FixupCollection<TripLog>;
    				if (newValue != null)
    				{
    					newValue.CollectionChanged += FixupTripLogs;
    				}
    			}
    		}
    	}
    	private ICollection<TripLog> _tripLogs;

        #endregion
        #region Association Fixup
    
    	private void FixupBoat(Boat previousValue)
    	{
    		if (previousValue != null && previousValue.Trips.Contains(this))
    		{
    			previousValue.Trips.Remove(this);
    		}
    
    		if (Boat != null)
    		{
    			if (!Boat.Trips.Contains(this))
    			{
    				Boat.Trips.Add(this);
    			}
    			if (BoatId != Boat.Id)
    			{
    				BoatId = Boat.Id;
    			}
    		}
    	}
    
    	private void FixupLocation(Location previousValue)
    	{
    		if (previousValue != null && previousValue.Trips.Contains(this))
    		{
    			previousValue.Trips.Remove(this);
    		}
    
    		if (Location != null)
    		{
    			if (!Location.Trips.Contains(this))
    			{
    				Location.Trips.Add(this);
    			}
    			if (DepartureLocId != Location.Id)
    			{
    				DepartureLocId = Location.Id;
    			}
    		}
    	}
    
    	private void FixupLocation1(Location previousValue)
    	{
    		if (previousValue != null && previousValue.Trips1.Contains(this))
    		{
    			previousValue.Trips1.Remove(this);
    		}
    
    		if (Location1 != null)
    		{
    			if (!Location1.Trips1.Contains(this))
    			{
    				Location1.Trips1.Add(this);
    			}
    			if (DestinationLocId != Location1.Id)
    			{
    				DestinationLocId = Location1.Id;
    			}
    		}
    	}
    
    	private void FixupTripLogs(object sender, NotifyCollectionChangedEventArgs e)
    	{
    		if (e.NewItems != null)
    		{
    			foreach (TripLog item in e.NewItems)
    			{
    				item.Trip = this;
    			}
    		}
    
    		if (e.OldItems != null)
    		{
    			foreach (TripLog item in e.OldItems)
    			{
    				if (ReferenceEquals(item.Trip, this))
    				{
    					item.Trip = null;
    				}
    			}
    		}
    	}

        #endregion
    }
}
