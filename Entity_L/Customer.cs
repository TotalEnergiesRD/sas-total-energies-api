using System;
using System.Collections.Generic;

namespace Entity_Layer
{
    public partial class Customer
    {
        public int IdCustomer { get; set; }
        public string Name { get; set; } = null!;
        public long? Telephone { get; set; }
        public long? Cellphone { get; set; }
        public string? Address { get; set; }
    }
}
