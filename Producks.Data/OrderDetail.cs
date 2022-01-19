using System;
using System.Collections.Generic;
using System.Text;

namespace Producks.Data
{
    public class OrderDetail
    {
        public int Id { get; set; }

        public int OrderId { get; set; }

        public int ProductId { get; set; }

        public int quantity { get; set; }

        public Order Order { get; set; }

        public Product Product { get; set; }
    }
}
