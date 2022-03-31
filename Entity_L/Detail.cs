using System;
using System.Collections.Generic;

namespace Entity_Layer
{
    public partial class Detail
    {
        public int IdDetails { get; set; }
        public string Name { get; set; } = null!;
        public int SubCategory { get; set; }
        public bool? Status { get; set; }
    }
}
