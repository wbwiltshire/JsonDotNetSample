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
    [MetadataType(typeof(LocationMetaData))]
    public partial class Location : StateObject
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
    
    	public decimal Latitude
    	{
    		get;
    		set;
    	}
    
    	public decimal Longitude
    	{
    		get;
    		set;
    	}
    
    	public string Street1
    	{
    		get;
    		set;
    	}
    
    	public string Street2
    	{
    		get;
    		set;
    	}
    
    	public int CityId
    	{
    		get { return _cityId; }
    		set
    		{
    			if (_cityId != value)
    			{
    				if (City != null && City.Id != value)
    				{
    					City = null;
    				}
    				_cityId = value;
    			}
    		}
    	}
    	private int _cityId;
    
    	public string ZipCode
    	{
    		get;
    		set;
    	}
    
    	public string PhoneNbr
    	{
    		get;
    		set;
    	}
    
    	public string Email
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
    
    	public City City
    	{
    		get { return _city; }
    		set
    		{
    			if (!ReferenceEquals(_city, value))
    			{
    				var previousValue = _city;
    				_city = value;
    				FixupCity(previousValue);
    			}
    		}
    	}
    	private City _city;
    
    	public ICollection<Trip> Trips
    	{
    		get
    		{
    			if (_trips == null)
    			{
    				var newCollection = new FixupCollection<Trip>();
    				newCollection.CollectionChanged += FixupTrips;
    				_trips = newCollection;
    			}
    			return _trips;
    		}
    		set
    		{
    			if (!ReferenceEquals(_trips, value))
    			{
    				var previousValue = _trips as FixupCollection<Trip>;
    				if (previousValue != null)
    				{
    					previousValue.CollectionChanged -= FixupTrips;
    				}
    				_trips = value;
    				var newValue = value as FixupCollection<Trip>;
    				if (newValue != null)
    				{
    					newValue.CollectionChanged += FixupTrips;
    				}
    			}
    		}
    	}
    	private ICollection<Trip> _trips;
    
    	public ICollection<Trip> Trips1
    	{
    		get
    		{
    			if (_trips1 == null)
    			{
    				var newCollection = new FixupCollection<Trip>();
    				newCollection.CollectionChanged += FixupTrips1;
    				_trips1 = newCollection;
    			}
    			return _trips1;
    		}
    		set
    		{
    			if (!ReferenceEquals(_trips1, value))
    			{
    				var previousValue = _trips1 as FixupCollection<Trip>;
    				if (previousValue != null)
    				{
    					previousValue.CollectionChanged -= FixupTrips1;
    				}
    				_trips1 = value;
    				var newValue = value as FixupCollection<Trip>;
    				if (newValue != null)
    				{
    					newValue.CollectionChanged += FixupTrips1;
    				}
    			}
    		}
    	}
    	private ICollection<Trip> _trips1;

        #endregion
        #region Association Fixup
    
    	private void FixupCity(City previousValue)
    	{
    		if (previousValue != null && previousValue.Locations.Contains(this))
    		{
    			previousValue.Locations.Remove(this);
    		}
    
    		if (City != null)
    		{
    			if (!City.Locations.Contains(this))
    			{
    				City.Locations.Add(this);
    			}
    			if (CityId != City.Id)
    			{
    				CityId = City.Id;
    			}
    		}
    	}
    
    	private void FixupTrips(object sender, NotifyCollectionChangedEventArgs e)
    	{
    		if (e.NewItems != null)
    		{
    			foreach (Trip item in e.NewItems)
    			{
    				item.Location = this;
    			}
    		}
    
    		if (e.OldItems != null)
    		{
    			foreach (Trip item in e.OldItems)
    			{
    				if (ReferenceEquals(item.Location, this))
    				{
    					item.Location = null;
    				}
    			}
    		}
    	}
    
    	private void FixupTrips1(object sender, NotifyCollectionChangedEventArgs e)
    	{
    		if (e.NewItems != null)
    		{
    			foreach (Trip item in e.NewItems)
    			{
    				item.Location1 = this;
    			}
    		}
    
    		if (e.OldItems != null)
    		{
    			foreach (Trip item in e.OldItems)
    			{
    				if (ReferenceEquals(item.Location1, this))
    				{
    					item.Location1 = null;
    				}
    			}
    		}
    	}

        #endregion
    }
}
