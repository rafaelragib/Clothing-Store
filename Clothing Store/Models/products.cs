using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Clothing_Store.Models
{
    public class products
    {
        [Key]
    public int p_id { get; set; }
    public string p_name { get; set; }
    public int price { get; set; }
    public int size { get; set; }
    public int quantity { get; set; }
   
    }
    public class productsDBContext : DbContext
        {
            public DbSet<products> products { get; set; }
        }
    
}
