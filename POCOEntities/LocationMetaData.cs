using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace EFDatabaseFirst.Data.POCOEntities
{
    [DataContract(Name="Location")]
    public partial class LocationMetaData
    {
        [Display(Name = "Id")]
        [DataMember(Order = 1)]
        public int Id { get; set; }

        [Display(Name = "Name")]
        [DataMember(Order = 2)]
        public string Name { get; set; }

        [Display(Name = "Latitude")]
        [DisplayFormat(DataFormatString = "{0:#0.0000000}", ApplyFormatInEditMode = true)]
        [DataMember(Order = 3)]
        public decimal Latitude { get; set; }

        [Display(Name = "Longitude")]
        [DisplayFormat(DataFormatString = "{0:#0.0000000}", ApplyFormatInEditMode = true)]
        [DataMember(Order = 4)]
        public decimal Longitude { get; set; }

        [Display(Name = "Address 1")]
        [DataMember(Order = 5)]
        public string Street1 { get; set; }

        [Display(Name = "Address 2")]
        [DataMember(Order = 6)]
        public string Street2 { get; set; }

        [DataMember(Order = 7)]
        public int CityId { get; set; }

        //[DataMember(Order = 8)]
        //public int StateId { get; set; }

        [DataMember(Order = 9)]
        //public int CountryId { get; set; }
        public City City { get; set; }

        [Display(Name = "Zip Code")]
        [DataMember(Order = 10)]
        public string ZipCode { get; set; }
        
        [Display(Name = "Phone Nbr.")]
        [DataMember(Order = 11)]
        public string PhoneNbr { get; set; }

        [Display(Name = "EMail")]
        [DataMember(Order = 12)]
        public string Email { get; set; }

        [Display(Name = "Active")]
        [DataMember(Order = 13)]
        public virtual bool Active { get; set; }

        [Display(Name = "Mod Date")]
        [DataMember(Order = 14)]
        public System.DateTime ModifiedDt { get; set; }

        [Display(Name = "Create Date")]
        [DataMember(Order = 15)]
        public System.DateTime CreateDt { get; set; }
    }
}
