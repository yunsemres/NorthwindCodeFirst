using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CodeFirstNorthwind.Models.ORM.Entity
{
    public class Order:BaseEntity
    {
        [Column(Order=2, TypeName ="int")]
        public int OrderID { get; set; }

        [Column(Order = 3, TypeName = "int")]
        public int CustomerID { get; set; }

        [ForeignKey("CustomerID")]
        public virtual Customer Customer { get; set; }

        [Column(Order = 4, TypeName = "int")]
        public int EmployeeID { get; set; }

        [ForeignKey("EmployeeID")]
        public virtual Employee Employee { get; set; }

        [Column(Order = 5, TypeName = "datetime")]
        public DateTime OrderDate { get; set; }

        [Column(Order = 6, TypeName = "datetime")]
        public DateTime RequiredDate { get; set; }

        [Column(Order = 7, TypeName = "datetime")]
        public DateTime ShippedDate { get; set; }

        [Column(Order = 8, TypeName = "int")]
        public int ShipVia { get; set; }

        [ForeignKey("ShipVia")]
        public virtual Shipper Shipper { get; set; }

        [Column(Order = 9, TypeName = "money")]
        public int Freight { get; set; }

        [Column(Order = 10, TypeName = "nvarchar")]
        [StringLength(40)]
        public string ShipName { get; set; }

        [Column(Order = 11, TypeName = "nvarchar")]
        [StringLength(60)]
        public string ShipAddress { get; set; }

        [Column(Order = 12, TypeName = "nvarchar")]
        [StringLength(15)]
        public string ShipCity { get; set; }

        [Column(Order = 13, TypeName = "nvarchar")]
        [StringLength(15)]
        public string ShipRegion { get; set; }

        [Column(Order = 14, TypeName = "nvarchar")]
        [StringLength(10)]
        public string ShipPostalCode { get; set; }

        [Column(Order = 15, TypeName = "nvarchar")]
        [StringLength(15)]
        public string ShipCountry { get; set; }
    }
}