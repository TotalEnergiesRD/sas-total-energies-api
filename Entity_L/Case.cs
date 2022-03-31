using System;
using System.Collections.Generic;

namespace Entity_Layer
{
    public partial class Case
    {
        public int IdCases { get; set; }
        public int CaseType { get; set; }
        public int? Category { get; set; }
        public int? SubCategory { get; set; }
        public int? Details { get; set; }
        public int Status { get; set; }
        public string Description { get; set; } = null!;
        public int Responsable { get; set; }
        public int IdCustomer { get; set; }
        public string? Date { get; set; }
        public string? Time { get; set; }
        public string? Extra { get; set; }
        public string Code { get; set; } = null!;
    }
}
