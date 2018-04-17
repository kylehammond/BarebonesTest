using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Barebones.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
        public bool IsSoftDeleted { get; set; }
    }
}