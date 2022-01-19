using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Producks.Web.ViewModels
{
    public class CustomerVM
    {
        public virtual int Id { get; set; }
        public virtual string CustName { get; set; }
        public virtual string CustEmail { get; set; }
        public virtual string CustPassword { get; set; }
        public virtual string Address { get; set; }
        public virtual string Contact { get; set; }
    }
}
