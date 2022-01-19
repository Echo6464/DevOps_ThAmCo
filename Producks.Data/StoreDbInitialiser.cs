using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Producks.Data
{
    public static class StoreDbInitialiser
    {
        public static async Task SeedTestData(StoreDb context,
                                              IServiceProvider services)
        {
            if (context.Products.Any() && context.Customers.Any())
            {
                //db seems to be seeded
                return;
            }


            var categories = new List<Category>
            {
                new Category { Name = "Covers", Description = "Davison Stores pride ourselves on our poor range of covers for your mobile device at premium prices.  If you're lukcy your phone or tablet will be protected from any dents, scratches and scuffs.", Active = true },
                new Category { Name = "Case", Description = "Browse our wide range of cases for phones and tablets that will help you to keep your mobile device protected from the elements.", Active = false },
                new Category { Name = "Accessories", Description = "We stock a small range of phone and tablet accessories, including car holders, sports armbands, stylus pens and very little else.", Active = true },
                new Category { Name = "Screen Protectors", Description = "Exclusive Davison Stores screen protectors for your phone or tablet.", Active = true }
            };
            categories.ForEach(c => context.Categories.Add(c));

            var brands = new List<Brand>
            {
                new Brand { Name = "Soggy Sponge", Active = true },
                new Brand { Name = "Damp Squib", Active = false },
                new Brand { Name = "iStuff-R-Us", Active = true }
            };
            brands.ForEach(b => context.Brands.Add(b));

            await context.SaveChangesAsync();

            var products = new List<Product>
            {
                new Product { Active = true, Brand = brands[0], Category = categories[0], Description = "Poor quality fake faux leather cover loose enough to fit any mobile device.", Name = "Wrap It and Hope Cover", Price = 5.99, StockLevel = 1 },
                new Product { Active = true, Brand = brands[1], Category = categories[0], Description = "Purchase you favourite chocolate and use the provided heating element to melt it into the perfect cover for your mobile device.", Name = "Chocolate Cover", Price = 10.97, StockLevel = 0 },
                new Product { Active = true, Brand = brands[2], Category = categories[0], Description = "Lamely adapted used and dirty teatowel.  Guaranteed fewer than two holes.", Name = "Cloth Cover", Price = 3.01, StockLevel = 6 },
                new Product { Active = true, Brand = brands[0], Category = categories[1], Description = "Especially toughen and harden sponge entirely encases your device to prevent any interaction.", Name = "Harden Sponge Case", Price = 9.99, StockLevel = 2 },
                new Product { Active = true, Brand = brands[0], Category = categories[1], Description = "Place your device within the water-tight container, fill with water and enjoy the cushioned protection from bumps and bangs.", Name = "Water Bath Case", Price = 20.0, StockLevel = 3 },
                new Product { Active = false, Brand = brands[0], Category = categories[2], Description = "Keep you smartphone handsfree with this large assembly that attaches to your rear window wiper (Hatchbacks only).", Name = "Smartphone Car Holder", Price = 110.01, StockLevel = 8 },
                new Product { Active = true, Brand = brands[0], Category = categories[2], Description = "Keep your device on your arm with this general purpose sticky tape.", Name = "Sticky Tape Sport Armband", Price = 2.99, StockLevel = 23 },
                new Product { Active = true, Brand = brands[1], Category = categories[2], Description = "Stengthen HB pencils guaranteed to leave a mark.", Name = "Real Pencil Stylus", Price = 0.99, StockLevel = 5 },
                new Product { Active = true, Brand = brands[0], Category = categories[3], Description = "Coat your mobile device screen in a scratch resistant, opaque film.", Name = "Spray Paint Screen Protector", Price = 4.99, StockLevel = 1 },
                new Product { Active = true, Brand = brands[2], Category = categories[3], Description = "For his or her sensory pleasure. Fits few known smartphones.", Name = "Rippled Screen Protector", Price = 7.99, StockLevel = 5 },
                new Product { Active = true, Brand = brands[2], Category = categories[3], Description = "For an odour than lingers on your device.", Name = "Fish Scented Screen Protector", Price = 2.88, StockLevel = 0 },
                new Product { Active = true, Brand = brands[1], Category = categories[3], Description = "Guaranteed not to conduct electical charge from your fingers.", Name = "Non-conductive Screen Protector", Price = 10.0, StockLevel = 10 },
            };
            products.ForEach(p => context.Products.Add(p));

            await context.SaveChangesAsync();

            var customers = new List<Customer>
            {
                new Customer { CustName = "Jack Norman", CustEmail = "jacknorman@gmail.com", CustPassword = "jacknorman123", Address = "13, Jalan SS5", Contact = "012-3345655" },
                new Customer { CustName = "Tan Jun Jie", CustEmail = "junjietan@gmail.com", CustPassword = "junjie123", Address = "15, Jalan BU 3", Contact = "017-5582300" },
                new Customer { CustName = "Li Mei Mei", CustEmail = "meimei@gmail.com", CustPassword = "meimei123", Address = "7, Jalan BU 1", Contact = "016-5788988" },

            };
            customers.ForEach(cm => context.Customers.Add(cm));

            await context.SaveChangesAsync();

            var staffs = new List<Staff>
            {
                new Staff { StaffName = "John Lee", StaffEmail = "johnlee@gmail.com", StaffPassword = "johnlee123", StaffRole = "Staff" },
                new Staff { StaffName = "Melissa Ng", StaffEmail = "melissang@gmail.com", StaffPassword = "melisa123", StaffRole = "Management" },
                new Staff { StaffName = "Tan Mei Li", StaffEmail = "meilitan@yahoo.com", StaffPassword = "meili123", StaffRole = "Staff" },  
            };
            staffs.ForEach(s => context.Staffs.Add(s));

            await context.SaveChangesAsync();

            var orders = new List<Order>
            {
                new Order{ CustId = 2, TotalPrice = 113, Order_Date = DateTime.Now, Order_Status = "Pending", Delivery_Date = null },
                new Order{ CustId = 3, TotalPrice = 20, Order_Date = DateTime.Now.AddDays(-1), Order_Status = "Dispatched", Delivery_Date = DateTime.Now },
            };
            orders.ForEach(o => context.Orders.Add(o));

            var orderdetails = new List<OrderDetail>
            {
                new OrderDetail{ OrderId = 1, ProductId = 1, quantity = 1},
                new OrderDetail{ OrderId = 1, ProductId = 2, quantity = 1},
                new OrderDetail{ OrderId = 2, ProductId = 3, quantity = 1},

            };
            orderdetails.ForEach(od => context.OrderDetails.Add(od));

            var reviews = new List<Review>
            {
                new Review { ProductId = 1, CustId = 2, Description = "This item is very useful!", Review_Date = DateTime.Now, Active = true },
                new Review { ProductId = 3, CustId = 3, Description = "This item is somewhat damaged when delievered, do take note on that!", Review_Date = DateTime.Now, Active = true },
                new Review { ProductId = 2, CustId = 2, Description = "This item is nice to use!", Review_Date = DateTime.Now, Active = false }
            };
            reviews.ForEach(r => context.Reviews.Add(r));

            await context.SaveChangesAsync();
        }
    }
}
