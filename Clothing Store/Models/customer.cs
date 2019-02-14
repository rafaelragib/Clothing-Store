using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Clothing_Store.Models
{
    public class customer
    {
        [Key]
        public int c_id { get; set; }
        public int c_name { get; set; }
        public int address_id { get; set; }
        public string phone { get; set; }
    }
    public class customerDBContext : DbContext
    {
        public DbSet<customer> customers { get; set; }
    }
}
