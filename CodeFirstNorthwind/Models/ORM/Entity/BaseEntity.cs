using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CodeFirstNorthwind.Models.ORM.Entity
{
    public class BaseEntity
    {
        [Column(Order=1)]
        public int ID { get; set; }

        private DateTime? _addDate = DateTime.Now;
        public DateTime? AddDate { get { return _addDate; } set { _addDate = value; } }

        private bool? _isDeleted = false;
        public bool? IsDeleted { get { return _isDeleted; } set { _isDeleted = value;  } }

        private DateTime? _deleteDate = DateTime.Now;
        public DateTime? DeleteDate { get { return _deleteDate; } set { _deleteDate = value; } }

        public DateTime? _updateDate = DateTime.Now;
        public DateTime? UpdateDate { get { return _updateDate; } set { _updateDate = value; } }
    }
}