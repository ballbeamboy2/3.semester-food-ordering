﻿namespace WebShopWebServerAPIClient1.Models.ViewModels {

        public class CartViewModel
        {
                public List<CartItem> CartItems { get; set; }
                public double GrandTotal { get; set; }
        }

}