
using System;
using System.Collections.Generic;

namespace Backend.Models
{
    public partial class Category
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Discount { get; set; }
        public int Stock { get; set; }
        public string Url_image { get; set; }
        public bool Is_promotion { get; set; }
        public bool Is_activate { get; set; }
    }
}