﻿using System;
using System.Collections.Generic;

namespace Entity_Layer
{
    public partial class TipoDeCaso
    {
        public int IdCaso { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Sla { get; set; }
    }
}
