using System;
using System.Collections.Generic;

namespace Database_First_MVC.Moodels
{
    public partial class Sales
    {
        public double? TotalCost { get; set; }
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
    }
}
