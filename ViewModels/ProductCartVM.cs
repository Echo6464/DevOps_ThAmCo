using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Producks.Web.Models;

namespace Producks.Web.ViewModels
{
    public class ProductCartVM
    {
        public List<ProductCart> _products { get; set; }
        /*public List<ProductCart> findAll()
        {
            _products = new List<ProductCart> { };
        }*/
        public virtual int ProductId { get; set; }
        public virtual string ProductName { get; set; }
        public virtual double ProductPrice { get; set; }
        public ProductCart Product { get; set; }
    }
}
