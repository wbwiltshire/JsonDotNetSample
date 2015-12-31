using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace EFDatabaseFirst.Data.POCOEntities
{
    public class TripLogMetaData
    {
        [Display(Name = "Id")]
        [DataMember(Order = 1)]
        public int Id { get; set; }

        [Display(Name = "TripId")]
        [DataMember(Order = 2)]
        public virtual int TripId { get; set; }

        [Display(Name = "Log Date")]
        [DisplayFormat(DataFormatString = "{0: MM/dd/yyyy HH:mm}", ApplyFormatInEditMode = true)]
        [DataMember(Order = 3)]
        public System.DateTime LogDt { get; set; }

        [Display(Name = "Latitude")]
        [DisplayFormat(DataFormatString = "{0:#0.0000000}", ApplyFormatInEditMode = true)]
        [DataMember(Order = 4)]
        public decimal Latitude { get; set; }

        [Display(Name = "Longitude")]
        [DisplayFormat(DataFormatString = "{0:#0.0000000}", ApplyFormatInEditMode = true)]
        [DataMember(Order = 5)]
        public decimal Longitude { get; set; }

        [Display(Name = "Boat Speed (Kts)")]
        [DataMember(Order = 6)]
        public virtual decimal BoatSpeed { get; set; }

        [Display(Name = "Course (º)")]
        [DataMember(Order = 7)]
        public virtual int Course { get; set; }

        [Display(Name = "Pressure (Mb)")]
        [DataMember(Order = 8)]
        public virtual int Pressure { get; set; }

        [DataMember(Order = 9)]
        public virtual int PressureDirId { get; set; }

        [Display(Name = "Wind Speed (Kts)")]
        [DataMember(Order = 10)]
        public virtual decimal WindSpeed { get; set; }

        [DataMember(Order = 11)]
        public virtual int WindDirId { get; set; }

        [DataMember(Order = 12)]
        public virtual int SeaStateId { get; set; }

        [DataMember(Order = 13)]
        public virtual int CloudCoverId { get; set; }

        [Display(Name = "Comments")]
        [DataMember(Order = 14)]
        public virtual string Comments { get; set; }

        [Display(Name = "Active")]
        [DataMember(Order = 15)]
        public System.DateTime Active { get; set; }        
        
        [Display(Name = "Mod Date")]
        [DataMember(Order = 16)]
        public System.DateTime ModifiedDt { get; set; }

        [Display(Name = "Create Date")]
        [DataMember(Order = 17)]
        public System.DateTime CreateDt { get; set; }
    }
}
