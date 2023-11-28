using System;
using System.ComponentModel.DataAnnotations;

namespace BookShopMvc.Models
{
	public class User
	{
		[Key]
		public int Id { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
		public string Fullname { get; set; }
		public string Phone { get; set; }
		public string Address { get; set; }
		public string City { get; set; }
		public string Img { get; set; }
		public int Role { get; set; }
		public DateTime Created_at { get; set; }
		public DateTime Update_at { get; set; }
        public virtual ICollection<Cart> Carts { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
        public virtual ICollection<Order> Orders { get; set; }


    }
}

