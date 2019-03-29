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
        
        public int ID { get; set; }
        public string c_name { get; set; }
        public string email { get; set; }
        public string pass { get; set; }
        public string phone { get; set; }
        
    }
    //public class customerDBContext : DbContext
    //{
    //    public DbSet<customer> customers { get; set; }
    //}
}
