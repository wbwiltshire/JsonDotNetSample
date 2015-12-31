using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace EFDatabaseFirst.Data.POCOEntities
{
    [DataContract(Name="State")]
    public partial class StateMetaData
    {
        [Display(Name = "Id")]
        [DataMember(Order = 1)]
        public int Id { get; set; }

        [DataMember(Order = 2)]
        public int CountryId { get; set; }
        
        [Display(Name = "State")]
        [DataMember(Order = 3)]
        public virtual string Name { get; set; }

    }
}
