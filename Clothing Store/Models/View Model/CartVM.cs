using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clothing_Store.Models.View_Model
{
    public class CartVM
    {
        public int ProductID { get; set; }
        public string name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Total { get { return Quantity * Price; } }

    }
}