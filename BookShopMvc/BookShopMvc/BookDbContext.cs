using System;
using BookShopMvc.Models;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;

namespace BookShopMvc
{
	public class BookDbContext: DbContext
	{
		public BookDbContext(DbContextOptions<BookDbContext> options):base(options)
		{
		}
        //public DbSet<test> tests { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Subcategory> Subcategories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Order_item> Order_items { get; set; }
    }
}

