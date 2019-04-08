﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Clothing_Store.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        public string name { get; set; }
    }
}