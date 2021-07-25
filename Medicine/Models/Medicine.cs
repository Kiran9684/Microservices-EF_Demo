using System;
using System.Collections.Generic;

#nullable disable

namespace Medicine.Models
{
    public partial class Medicine
    {
        public int MedId { get; set; }
        public string MedName { get; set; }
        public double? Price { get; set; }
    }
}
