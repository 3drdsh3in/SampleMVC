﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class CreateProductViewModel
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }
}