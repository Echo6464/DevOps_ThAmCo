using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Producks.Data
{
    public class Review
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        [ForeignKey("Customer")]
        public int CustId { get; set; }

        public string Description { get; set; }

        [DataType(DataType.Date)]
        public DateTime Review_Date { get; set; }

        public bool Active { get; set; }

        public Product Product { get; set; }

        public Customer Customer { get; set; }
    }
}
