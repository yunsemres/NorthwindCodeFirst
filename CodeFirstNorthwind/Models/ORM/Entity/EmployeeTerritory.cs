using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CodeFirstNorthwind.Models.ORM.Entity
{
    public class EmployeeTerritory:BaseEntity
    {
        public int EmployeeID { get; set; }
        [ForeignKey("EmployeeID")]
        public virtual Employee Employee { get; set; }

        public int TerritoryID { get; set; }
        [ForeignKey("TerritoryID")]
        public virtual Territory Territory { get; set; }
    }
}