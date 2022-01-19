using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Producks.Data;

namespace Producks.Web.ViewModels
{
    public class ReviewVM
    {
        public virtual int Id { get; set; }

        public virtual int ProductId { get; set; }

        public virtual int CustId { get; set; }

        public virtual string Description { get; set; }

        [DataType(DataType.Date)]
        public virtual DateTime Review_Date { get; set; }

        public virtual bool Active { get; set; }

        public ProductVM Product { get; set; }

        public virtual string ProductName { get; set; }

        public CustomerVM Customer { get; set; }
        public virtual string CustName { get; set; }
    }
}
