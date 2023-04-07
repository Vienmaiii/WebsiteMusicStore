using System;
using System.Collections.Generic;
using WebsiteMusic.Models;

namespace WebsiteMusic.ModelViews
{
    public class XemDonHang
    {
        public Order DonHang { get; set; }
        public List<OrderDetail> ChiTietDonHang { get; set; }
    }
}
