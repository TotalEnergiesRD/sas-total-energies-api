using System;
using System.Collections.Generic;

namespace Entity_Layer
{
    public partial class CaseType
    {
        public int IdCaseType { get; set; }
        public string Name { get; set; } = null!;
        public string? Sla { get; set; }
        public bool? Status { get; set; }
    }
}
