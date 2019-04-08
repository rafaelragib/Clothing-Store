using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Clothing_Store.Models;

namespace Clothing_Store.DAL
{
    public class CustomerInit : System.Data.Entity.DropCreateDatabaseIfModelChanges<ShopContext>
    {
        //protected override void Seed(ShopContext context)
        //{
        //    var customers = new List<customer>
        //    {
        //        new customer{c_name="Carson",email="ab@g.com",pass="abcd",phone="012"},
        //        new customer{c_name="mason",email="abcd@g.com",pass="dabcd",phone="0122"}
        //    };
        //    var categories = new List<Category>
        //    {
        //        new Category{name="Male"},
        //        new Category{name="Female"},
        //        new Category{name="Kids"}
        //    };
        //    var products = new List<Product>
        //    {
        //        new Product{name="Shirt",quantity=10,CategoryID=1},
        //        new Product{name="Jeans",quantity=4,CategoryID=1},
        //        new Product{name="T-Shirts",quantity=2,CategoryID=3}
        //    };
        //    customers.ForEach(s => context.Customers.Add(s));
        //    categories.ForEach(s => context.Categories.Add(s));
        //    products.ForEach(s => context.Products.Add(s));
        //    context.SaveChanges();
        //}
    }
}