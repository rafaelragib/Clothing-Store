using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Clothing_Store.Models
{
    public class category
    {
        [Key]
        public int category_id { get; set; }
        public int p_id { get; set; }
        public string category_name { get; set; }
    }
    public class categoryDBContext : DbContext
    {
        public DbSet<category> category { get; set; }
    }
}