using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KODMARK_new.Models
{
    public class SingleProductModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string Definition { get; set; }
        public List<ProductImage> ProductImages { get; set; }
    }
}