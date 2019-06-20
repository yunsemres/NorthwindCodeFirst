using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CodeFirstNorthwind.Models.ORM.Entity
{
    public class Shipper:BaseEntity
    {
        [Column(Order =2,TypeName ="int")]
        public int ShipperID { get; set; }

        [Column(Order = 3, TypeName = "nvarchar")]
        [StringLength(40)]
        public string CompanyName { get; set; }

        [Column(Order = 4, TypeName = "nvarchar")]
        [StringLength(24)]
        public string Phone { get; set; }
    }
}