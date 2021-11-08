﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Books_Management.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
    }
}