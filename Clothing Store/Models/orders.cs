using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Clothing_Store.Models
{
    public class orders
    {
        [Key]
        public int o_id { get; set; }
        public string p_id { get; set; }
        public DateTime deliverydate { get; set; }
        public int totalprice { get; set; }
    }
    public class ordersDBContext : DbContext
    {
        public DbSet<orders> orders { get; set; }
    }
}
