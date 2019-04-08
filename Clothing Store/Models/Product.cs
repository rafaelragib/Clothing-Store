using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clothing_Store.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string name { get; set;}
        public int quantity { get; set; } 
        public int price { get; set; } 
        public string image { get; set; } 
        public int CategoryID { get; set; }
    }
}