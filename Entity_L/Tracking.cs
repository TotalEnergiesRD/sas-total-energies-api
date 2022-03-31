using System;
using System.Collections.Generic;

namespace Entity_Layer
{
    public partial class Tracking
    {
        public int IdTracking { get; set; }
        public string Date { get; set; } = null!;
        public long CodeUser { get; set; }
        public string Description { get; set; } = null!;
        public string? Time { get; set; }
        public int? IdCase { get; set; }
    }
}
