using System;
using System.Collections.Generic;

namespace Database_First_MVC.Moodels
{
    public partial class Customers
    {
        public Customers()
        {
            Orders = new HashSet<Orders>();
        }

        public int CustomerId { get; set; }
        public string Forename { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
    }
}
