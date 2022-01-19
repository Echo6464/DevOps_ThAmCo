using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Producks.Data
{
    public class Order
    {
        public int Id { get; set; }

        [ForeignKey("Customer")]
        public int CustId { get; set; }

        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double TotalPrice { get; set; }

        [DataType(DataType.Date)]
        public DateTime Order_Date { get; set; }

        public string Order_Status { get; set; }

        public DateTime? Delivery_Date { get; set; }
        public Customer Customer { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
    }
}
