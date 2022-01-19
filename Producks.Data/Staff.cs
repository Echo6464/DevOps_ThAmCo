using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace Producks.Data
{
    public class Staff
    {
        public int StaffId { get; set; }
        public string StaffName { get; set; }
        public string StaffEmail { get; set; }
        public string StaffPassword { get; set; }
        public string StaffRole { get; set; }
    }
}
