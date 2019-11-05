using System;
using System.Collections.Generic;

namespace Database_First_MVC.Moodels
{
    public partial class OrderDetails
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public virtual Orders Order { get; set; }
        public virtual Products Product { get; set; }
    }
}
