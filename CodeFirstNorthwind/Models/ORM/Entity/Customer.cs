using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CodeFirstNorthwind.Models.ORM.Entity
{
    public class Customer:BaseEntity,IBase
    {
        [Column(Order=2)]
        public int CustomerID { get; set; }

        [Required]
        [Column(Order=3,TypeName = "nvarchar")]
        [StringLength(40)]
        public string CompanyName { get; set; }

        [Column(Order = 4, TypeName = "nvarchar")]
        [StringLength(30)]
        public string ContactName { get; set; }

        [Column(Order=5, TypeName = "nvarchar")]
        [StringLength(30)]
        public string ContactTitle { get; set; }

        [Column(Order = 6, TypeName = "nvarchar")]
        [StringLength(60)]
        public string Adress { get; set; }

        [Column(Order = 7, TypeName = "nvarchar")]
        [StringLength(15)]
        public string City { get; set; }

        [Column(Order = 8, TypeName = "nvarchar")]
        [StringLength(15)]
        public string Region { get; set; }

        [Column(Order = 9, TypeName = "nvarchar")]
        [StringLength(10)]
        public string PostalCode { get; set; }

        [Column(Order = 10, TypeName = "nvarchar")]
        [StringLength(15)]
        public string Country { get; set; }

        [Column(Order = 11, TypeName = "nvarchar")]
        [StringLength(24)]
        public string Phone { get; set; }

        [Column(Order = 12, TypeName = "nvarchar")]
        [StringLength(24)]
        public string Fax { get; set; }
    }
}