using Microsoft.AspNetCore.Mvc.Rendering;
using Producks.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Producks.Web.ViewModels
{
    public class ProductVM
    {
        public virtual int Id { get; set; }
        public virtual string Category { get; set; }
        public virtual string Brand { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual double Price { get; set; }
        public int StockLevel { get; set; }
        public bool Undercutters { get; set; }
        public bool inStock { get; set; }

        public string StockStatus {
            get {
                return (StockLevel > 0 || inStock) ? "In Stock" : "Out of Stock! Please Replenish Stock!";
            }
            set {
                return;
            }
        }

        public List<Product> Products { get; set; }
        public SelectList Brands { get; set; }
        public SelectList Categories { get; set; }

        public string ProdBrand { get; set; }
        public string ProdCat { get; set; }
        public string SearchString { get; set; }

        public List<Review> Reviews { get; set; }
        public List<Customer> Customers { get; set; }
    }
}
