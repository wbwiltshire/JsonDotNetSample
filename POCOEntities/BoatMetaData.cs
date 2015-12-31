using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace EFDatabaseFirst.Data.POCOEntities
{
    public class BoatMetaData
    {
        [Display(Name = "Id")]
        [DataMember(Order = 1)]
        public int Id { get; set; }

        [Display(Name = "Name")]
        [DataMember(Order = 2)]
        public virtual string Name { get; set; }

        [DataMember(Order = 3)]
        public int ManufacturerId { get; set; }

        [Display(Name = "Length")]
        [DataMember(Order = 4)]
        public int Length { get; set; }

        [Display(Name = "Active")]
        [DataMember(Order = 5)]
        public virtual bool Active { get; set; }

        [Display(Name = "Mod Date")]
        [DataMember(Order = 6)]
        public System.DateTime ModifiedDt { get; set; }

        [Display(Name = "Create Date")]
        [DataMember(Order = 7)]
        public System.DateTime CreateDt { get; set; }
    }
}
