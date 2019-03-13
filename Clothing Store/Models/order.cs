using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Clothing_Store.Models
{
    public class order
    {
        [Key]
        public int o_id { get; set; }
        public string p_id { get; set; }
        public DateTime deliverydate { get; set; }
        public int totalprice { get; set; }
    }
    public class orderDBContext : DbContext
    {
        public DbSet<order> orders { get; set; }
    }
}