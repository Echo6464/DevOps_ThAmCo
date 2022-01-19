using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Producks.Data;

namespace Producks.Web.ViewModels
{
    public class ProductReviewsVM
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

        public string StockStatus
        {
            get
            {
                return (StockLevel > 0 || inStock) ? "in stock" : "out of stock";
            }
            set
            {
                return;
            }
        }

        public List<Product> Products { get; set; }
        public SelectList Brands { get; set; }
        public SelectList Categories { get; set; }

        public string ProdBrand { get; set; }
        public string ProdCat { get; set; }
        public string SearchString { get; set; }

        public virtual int ReviewId { get; set; }
        public virtual string ReviewDescription { get; set; }
        public virtual DateTime ReviewDate { get; set; }

        public virtual bool Active { get; set; }

        public virtual int CustId { get; set; }
        public virtual string CustName { get; set; }

        public List<Review> Reviews { get; set; }
        public List<Customer> Customers { get; set; }
    }
}
