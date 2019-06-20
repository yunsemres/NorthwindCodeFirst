using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CodeFirstNorthwind.Models.ORM.Entity
{
    public class Territory: BaseEntity
    {
        [Column(Order=2,TypeName ="int")]
        public int TerritoryID { get; set; }

        [Column(Order = 3, TypeName = "nchar")]
        [StringLength(50)]
        public string TerritoryDescription { get; set; }

        [Column(Order = 4, TypeName = "int")]
        public int RegionID { get; set; }

        [ForeignKey("RegionID")]
        public virtual Region Region { get; set; }
    }
}