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
    [MetadataType(typeof(StateMetaData))]
    public partial class State : StateObject
    {
        #region Primitive Properties
    
    	public int Id
    	{
    		get;
    		set;
    	}
    
    	public int CountryId
    	{
    		get { return _countryId; }
    		set
    		{
    			if (_countryId != value)
    			{
    				if (Country != null && Country.Id != value)
    				{
    					Country = null;
    				}
    				_countryId = value;
    			}
    		}
    	}
    	private int _countryId;
    
    	public string Name
    	{
    		get;
    		set;
    	}

        #endregion
        #region Navigation Properties
    
    	public ICollection<City> Cities
    	{
    		get
    		{
    			if (_cities == null)
    			{
    				var newCollection = new FixupCollection<City>();
    				newCollection.CollectionChanged += FixupCities;
    				_cities = newCollection;
    			}
    			return _cities;
    		}
    		set
    		{
    			if (!ReferenceEquals(_cities, value))
    			{
    				var previousValue = _cities as FixupCollection<City>;
    				if (previousValue != null)
    				{
    					previousValue.CollectionChanged -= FixupCities;
    				}
    				_cities = value;
    				var newValue = value as FixupCollection<City>;
    				if (newValue != null)
    				{
    					newValue.CollectionChanged += FixupCities;
    				}
    			}
    		}
    	}
    	private ICollection<City> _cities;
    
    	public Country Country
    	{
    		get { return _country; }
    		set
    		{
    			if (!ReferenceEquals(_country, value))
    			{
    				var previousValue = _country;
    				_country = value;
    				FixupCountry(previousValue);
    			}
    		}
    	}
    	private Country _country;

        #endregion
        #region Association Fixup
    
    	private void FixupCountry(Country previousValue)
    	{
    		if (previousValue != null && previousValue.States.Contains(this))
    		{
    			previousValue.States.Remove(this);
    		}
    
    		if (Country != null)
    		{
    			if (!Country.States.Contains(this))
    			{
    				Country.States.Add(this);
    			}
    			if (CountryId != Country.Id)
    			{
    				CountryId = Country.Id;
    			}
    		}
    	}
    
    	private void FixupCities(object sender, NotifyCollectionChangedEventArgs e)
    	{
    		if (e.NewItems != null)
    		{
    			foreach (City item in e.NewItems)
    			{
    				item.State = this;
    			}
    		}
    
    		if (e.OldItems != null)
    		{
    			foreach (City item in e.OldItems)
    			{
    				if (ReferenceEquals(item.State, this))
    				{
    					item.State = null;
    				}
    			}
    		}
    	}

        #endregion
    }
}
