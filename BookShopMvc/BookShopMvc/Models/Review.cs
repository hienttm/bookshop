using System;
using System.ComponentModel.DataAnnotations;

namespace BookShopMvc.Models
{
	public class Review
	{
		[Key]
		public int Id { get; set; }
		public int Product_ID { get; set; }
        public virtual Product Product { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public int Star_rate { get; set; }
		public string Comment { get; set; }
		public string Slug { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime Update_at { get; set; }
    }
}

