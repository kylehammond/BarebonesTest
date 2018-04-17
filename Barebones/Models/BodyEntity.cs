using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Barebones.Models
{
    public class BodyEntity : BaseEntity
    {
        public string BodyType { get; set; }
        public int Weight { get; set; }
    }
}