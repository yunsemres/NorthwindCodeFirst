using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CodeFirstNorthwind.Models.ORM.Entity
{
    public class Region:BaseEntity
    {
        [Column(Order =2,TypeName ="int")]
        public int RegionID { get; set; }

        [Column(Order = 3, TypeName = "nchar")]
        [StringLength(50)]
        public string RegionDescription { get; set; }
    }
}