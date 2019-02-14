﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Clothing_Store.Models
{
    public class address
    {
        [Key]
        public int address_id { get; set; }
        public string city { get; set; }
        public int zipcode { get; set; }
        public string houseno { get; set; }
        public string road { get; set; }
        public string area { get; set; }
        
    }
    public class addressDBContext : DbContext
    {
        public DbSet<address> address { get; set; }
    }
}
