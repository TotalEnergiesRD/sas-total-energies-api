using System;
using System.Collections.Generic;

namespace Entity_Layer
{
    public partial class SubCategory
    {
        public int IdSubCategory { get; set; }
        public string Name { get; set; } = null!;
        public int Category { get; set; }
        public bool? Status { get; set; }
    }
}
