﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Producks.Data
{
    public class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int StockLevel { get; set; }
        public bool Active { get; set; }

        public Category Category { get; set; }
        public Brand Brand { get; set; }

        public List<Review> Reviews { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
    }
}
