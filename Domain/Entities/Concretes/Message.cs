using Domain.Entities.Abstracts;
using Domain.Identity;

namespace Domain.Entities.Concretes
{
	public class Message:Entity
	{
		public int ChatId { get; set; }
		public int SenderId { get; set; }
		public string Content { get; set; }
        public bool IsSeen { get; set; }

        // Navigation properties
        public Chat Chat { get; set; }
		public AppUser Sender { get; set; }
	}
}
