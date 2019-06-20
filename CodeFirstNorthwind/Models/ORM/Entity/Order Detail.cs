using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CodeFirstNorthwind.Models.ORM.Entity
{
    public class Order_Details:BaseEntity
    {
        [Column(Order=2)]
        public int OrderID { get; set; }

        [ForeignKey("OrderID")]
        public virtual Order Order { get; set; }

        [Column(Order=3)]
        public int ProductID { get; set; }

        [ForeignKey("ProductID")]
        public virtual Product Product { get; set; }

        [Column(Order = 4,TypeName ="int")]
        public int Quantity { get; set; }

        [Column(Order = 5, TypeName = "int")]
        public int Discontinued { get; set; }
    }
}