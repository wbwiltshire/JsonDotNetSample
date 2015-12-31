using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace EFDatabaseFirst.Data.POCOEntities
{
    public class TripMetaData
    {
        [Display(Name = "Id")]
        [DataMember(Order = 1)]
        public int Id { get; set; }

        [Display(Name = "Name")]
        [DataMember(Order = 2)]
        public virtual string Name { get; set; }

        [DataMember(Order = 3)]
        public int BoatId { get; set; }

        [DataMember(Order = 4)]
        public int DepartureLocId { get; set; }

        [Display(Name = "Departure Date")]
        [DisplayFormat(DataFormatString = "{0: MM/dd/yyyy HH:mm}", ApplyFormatInEditMode = true)]
        [DataMember(Order = 5)]
        public System.DateTime DepartureDt { get; set; }

        [DataMember(Order = 6)]
        public int DestinationLocId { get; set; }

        [Display(Name = "Arrival Date")]
        [DisplayFormat(DataFormatString = "{0: MM/dd/yyyy HH:mm}", ApplyFormatInEditMode = true)]
        [DataMember(Order = 7)]
        public System.DateTime ArrivalDt { get; set; }

        [Display(Name = "Active")]
        [DataMember(Order = 8)]
        public virtual bool Active { get; set; }

        [Display(Name = "Mod Date")]
        [DataMember(Order = 9)]
        public System.DateTime ModifiedDt { get; set; }

        [Display(Name = "Create Date")]
        [DataMember(Order = 10)]
        public System.DateTime CreateDt { get; set; }
    }
}
