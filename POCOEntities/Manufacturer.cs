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
    [MetadataType(typeof(ManufacturerMetaData))]
    public partial class Manufacturer : StateObject
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

        #endregion
        #region Navigation Properties
    
    	public ICollection<Boat> Boats
    	{
    		get
    		{
    			if (_boats == null)
    			{
    				var newCollection = new FixupCollection<Boat>();
    				newCollection.CollectionChanged += FixupBoats;
    				_boats = newCollection;
    			}
    			return _boats;
    		}
    		set
    		{
    			if (!ReferenceEquals(_boats, value))
    			{
    				var previousValue = _boats as FixupCollection<Boat>;
    				if (previousValue != null)
    				{
    					previousValue.CollectionChanged -= FixupBoats;
    				}
    				_boats = value;
    				var newValue = value as FixupCollection<Boat>;
    				if (newValue != null)
    				{
    					newValue.CollectionChanged += FixupBoats;
    				}
    			}
    		}
    	}
    	private ICollection<Boat> _boats;

        #endregion
        #region Association Fixup
    
    	private void FixupBoats(object sender, NotifyCollectionChangedEventArgs e)
    	{
    		if (e.NewItems != null)
    		{
    			foreach (Boat item in e.NewItems)
    			{
    				item.Manufacturer = this;
    			}
    		}
    
    		if (e.OldItems != null)
    		{
    			foreach (Boat item in e.OldItems)
    			{
    				if (ReferenceEquals(item.Manufacturer, this))
    				{
    					item.Manufacturer = null;
    				}
    			}
    		}
    	}

        #endregion
    }
}