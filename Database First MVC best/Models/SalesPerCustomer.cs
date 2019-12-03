using System;
using System.Collections.Generic;

namespace Database_First_MVC.Moodels
{
    public partial class SalesPerCustomer
    {
        public int CustomerId { get; set; }
        public int OrderId { get; set; }
        public double? TotalCost { get; set; }
    }
}
