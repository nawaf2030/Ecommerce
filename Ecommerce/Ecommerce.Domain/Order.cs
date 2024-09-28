
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain
{
	public class Order
	{
        public int Id { get; set; }
        [Required]
        public DateTime OrderDate { get; set; }
        [Required]
        public decimal TotalAmount { get; set; }
        //public OrderStatus Status { get; set; }
		public int UserId { get; set; }
		public User User { get; set; }
		public ICollection<OrderItem> OrderItems { get; set; }
	}
}
