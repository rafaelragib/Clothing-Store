using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Clothing_Store.Models
{
    public class moderator
    {
        [Key]
        public int admin_id { get; set; }
        public string name { get; set; }
        public string designation { get; set; }
    }
    public class moderatorDBContext : DbContext
    {
        public DbSet<moderator> moderator { get; set; }
    }
}
