using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace EFDatabaseFirst.Data.POCOEntities
{
    [DataContract(Name="Country")]
    public partial class CountryMetaData
    {
        [Display(Name = "Id")]
        [DataMember(Order = 1)]
        public int Id { get; set; }

        [Display(Name = "Country")]
        [DataMember(Order = 2)]
        public virtual string Name { get; set; }

    }
}
