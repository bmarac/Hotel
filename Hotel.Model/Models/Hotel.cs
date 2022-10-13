using System;
using System.Collections.Generic;

namespace Hotel.Model.Models
{
    public partial class Hotel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public double? Price { get; set; }
        public string? City { get; set; }
    }
}
