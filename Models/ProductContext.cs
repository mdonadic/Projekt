﻿using System.Data.Entity;
namespace PinWebForms.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("PinWebForms")
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<CartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}