﻿namespace Pratik_Basic_MVC_Projesi.Models
{
    public class CustomerOrderViewModel
    {
        public Customer Customer { get; set; } // Müşteri bilgisi
        public List<Order> Orders { get; set; } // Siparişlerin listesi
    }
}
