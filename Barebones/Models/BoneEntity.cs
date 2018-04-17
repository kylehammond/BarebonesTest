using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Barebones.Models
{
    public class BoneEntity : BaseEntity
    {
        public int Density { get; set; }
        public string Color { get; set; }
    }
}