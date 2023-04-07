using System;
using System.Collections.Generic;
using WebsiteMusic.Models;

namespace WebsiteMusic.ModelViews
{
    public class ProductHomeVM
    {
        public Category category { get; set; }
        public List<Product> lsProducts { get; set; }
    }
}
