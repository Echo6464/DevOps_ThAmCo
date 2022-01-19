using System;
using System.Collections.Generic;
using System.Text;

namespace Producks.Data
{
    public class Customer
    {
        public int Id { get; set; }
        public string CustName { get; set; }
        public string CustEmail { get; set; }
        public string CustPassword { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }

        public List<Order> Orders { get; set; }
    }
}
