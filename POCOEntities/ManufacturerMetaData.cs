﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace EFDatabaseFirst.Data.POCOEntities
{
    public class ManufacturerMetaData
    {
        [Display(Name = "Id")]
        [DataMember(Order = 1)]
        public int Id { get; set; }

        [Display(Name = "Mfg Name")]
        [DataMember(Order = 2)]
        public virtual string Name { get; set; }

    }
}
