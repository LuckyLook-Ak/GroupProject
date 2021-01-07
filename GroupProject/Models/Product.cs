﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GroupProject.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [StringLength(1024)]
        public string ProductImage { get; set; }
        public decimal Price { get; set; }
        public Category Category { get; set; }
        public Manufactorer Manufactorer{get;set;}
    }
}