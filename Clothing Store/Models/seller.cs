using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Clothing_Store.Models
{
    public class seller
    {
        [Key]
        public int s_id { get; set; }
        public string s_name { get; set; }
        public int address_id { get; set; }
        public string phone { get; set; }
    }
    public class sellerDBContext : DbContext
    {
        public DbSet<seller> seller { get; set; }
    }
}
