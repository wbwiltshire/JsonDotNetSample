using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace EFDatabaseFirst.Data.POCOEntities
{
    [DataContract(Name="City")]
    public partial class CityMetaData
    {
        [Display(Name = "Id")]
        [DataMember(Order = 1)]
        public int Id { get; set; }

        [DataMember(Order = 2)]
        public int StateId { get; set; }
        
        [Display(Name = "City")]
        [DataMember(Order = 3)]
        public string Name { get; set; }

        [DataMember(Order = 4)]
        public State State { get; set; }


    }
}
