using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CodeFirstNorthwind.Models.ORM.Entity
{
    public class Category:BaseEntity
    {
        [Column(Order = 2)]
        public int CategoryID { get; set; }
        [Required]
        [StringLength(15)]
        [Column(Order=3,TypeName = "nvarchar")]
        public string CategoryName { get; set; }

        [StringLength(255)]
        [Column(Order=4 ,TypeName="ntext")]
        public string Description { get; set; }

    }
}