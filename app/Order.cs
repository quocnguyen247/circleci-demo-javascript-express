﻿using System;
using System.Collections.Generic;

namespace OrderSystem
{
    public enum ProductType
    {
        CD,
        DVD,
        Book,
        Clothes,
        Game
    }

    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ProductType Type { get; set; }
    }

    public class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }
    }

    public class Order 
    { 
        public List<OrderItem> Items { get; set; }
        public DateTime Created { get; set; }
    }
}
