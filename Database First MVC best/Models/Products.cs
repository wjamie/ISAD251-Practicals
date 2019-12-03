using System;
using System.Collections.Generic;

namespace Database_First_MVC.Moodels
{
    public partial class Products
    {
        public Products()
        {
            OrderDetails = new HashSet<OrderDetails>();
        }

        public int ProductId { get; set; }
        public string ProductDetails { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
