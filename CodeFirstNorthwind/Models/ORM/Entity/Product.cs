using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CodeFirstNorthwind.Models.ORM.Entity
{
    public class Product:BaseEntity
    {
        [Column(Order=2,TypeName ="int")]
        public int ProductID { get; set; }

        [Column(Order = 3, TypeName = "nvarchar")]
        [StringLength(40)]
        public string ProductName { get; set; }

        [Column(Order = 4, TypeName = "int")]
        public int SupplierID { get; set; }

        [ForeignKey("SupplierID")]
        public virtual Supplier Supplier { get; set; }

        [Column(Order = 5, TypeName = "int")]
        public int CategoryID { get; set; }

        [ForeignKey("CategoryID")]
        public virtual Category Category { get; set; }

        [Column(Order = 6, TypeName = "nvarchar")]
        [StringLength(20)]
        public string QuantityPerUnit { get; set; }

        [Column(Order = 7, TypeName = "money")]
        public int UnitPrice { get; set; }

        [Column(Order = 8, TypeName = "int")]
        public int UnitInStock { get; set; }

        [Column(Order = 9, TypeName = "int")]
        public int UnitsOnOrder { get; set; }

        [Column(Order = 10, TypeName = "int")]
        public int ReorderLevel { get; set; }

        [Column(Order = 11, TypeName = "int")]
        public int Discontinued { get; set; }

        public int Supp { get; set; }
    }
}