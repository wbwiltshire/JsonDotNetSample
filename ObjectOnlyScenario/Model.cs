using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ObjectOnlyScenario
{
    [MetadataType(typeof(LocationMetaData))]
    public partial class Location : StateObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
    }

    [MetadataType(typeof(CityMetaData))]
    public partial class City : StateObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int StateId { get; set; }
        public State State { get; set; }
        public ICollection<Location> Locations { get; set; }
    }

    [MetadataType(typeof(StateMetaData))]
    public partial class State : StateObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<City> Cities { get; set; }
    }

    [DataContract(Name="StateObject", IsReference = true)]
    //[DataContract(Name = "StateObject")]
    //[DataContract(IsReference = true)]
    public class StateObject
    {
        [DataMember(Order = 0)]
        public int ObjectState { get; set; }
    }

    //
    //Begin the MetaData Definitions
    //

    [DataContract(Name = "Location")]
    public partial class LocationMetaData
    {
        [DataMember(Order = 1)]
        public int Id { get; set; }
        [DataMember(Order = 2)]
        [Display(Name = "Location Name")]
        public string Name { get; set; }
        [DataMember(Order = 3)]
        public City City { get; set; }
    }
    [DataContract(Name = "City")]
    public partial class CityMetaData
    {
        [DataMember(Order = 1)]
        public int Id { get; set; }
        [DataMember(Order = 2)]
        [Display(Name = "City Name")]
        public string Name { get; set; }
        [DataMember(Order = 3)]
        public int StateId { get; set; }
        [DataMember(Order = 4)]
        public State State { get; set; }
    }
    [DataContract(Name = "State")]
    public partial class StateMetaData
    {
        [DataMember(Order = 1)]
        public int Id { get; set; }
        [Display(Name = "State Name")]
        [DataMember(Order = 2)]
        public string Name { get; set; }
    }
}
