﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class User
    {
        public int id { get; set; }
        public string Name { get; set; }
        public bool admin { get; set; }
    }
}