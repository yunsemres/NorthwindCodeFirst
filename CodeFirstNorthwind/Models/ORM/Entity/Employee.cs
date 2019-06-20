using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CodeFirstNorthwind.Models.ORM.Entity
{
    public class Employee:BaseEntity,IBase
    {
        [Column(Order=2)]
        public int EmployeeID { get; set; }

        [Required]
        [Column(Order = 3, TypeName = "nvarchar")]
        [StringLength(10)]
        public string LastName { get; set; }


        [Required]
        [Column(Order = 4, TypeName = "nvarchar")]
        [StringLength(10)]
        public string FirstName { get; set; }

        [Required]
        [Column(Order = 5, TypeName = "nvarchar")]
        [StringLength(30)]
        public string Title { get; set; }

        [Required]
        [Column(Order = 6, TypeName = "nvarchar")]
        [StringLength(25)]
        public string TitleofCourtesy { get; set; }

        [Column(Order = 7, TypeName = "datetime")]
        public DateTime BirthDate { get; set; }

        [Column(Order = 8, TypeName = "datetime")]
        public DateTime HireDate { get; set; }

        [Column(Order = 9, TypeName = "nvarchar")]
        [StringLength(24)]
        public string HomePhone { get; set; }

        [Column(Order = 10, TypeName = "nvarchar")]
        [StringLength(4)]
        public string Extension { get; set; }

        [Column(Order = 11, TypeName = "nvarchar")]
        [StringLength(4)]
        public string Photo { get; set; }

        [Column(Order = 12, TypeName = "ntext")]
        public string Notes { get; set; }

        [Column(Order = 13, TypeName = "int")]
        public int ReportsTo { get; set; }

        [Column(Order = 14, TypeName = "nvarchar")]
        [StringLength(255)]
        public string PhotoPath { get; set; }

        [Column(Order = 15, TypeName = "nvarchar")]
        public string Adress { get; set; }

        [Column(Order = 16, TypeName = "nvarchar")]
        public string City { get; set; }

        [Column(Order = 17, TypeName = "nvarchar")]
        public string Region { get; set; }

        [Column(Order = 18, TypeName = "nvarchar")]
        public string PostalCode { get; set; }

        [Column(Order = 19, TypeName = "nvarchar")]
        public string Country { get; set; }

        [Column(Order = 20, TypeName = "nvarchar")]
        public string Phone { get; set; }
    }
}