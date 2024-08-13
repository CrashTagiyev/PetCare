using Domain.Entities.Abstracts;
using Domain.Identity;

namespace Domain.Entities.Concretes
{
	public class Notification : Entity
	{
		public string SenderUserName { get; set; }
		public string ReceiverUserName { get; set; }
		public string Content { get; set; }


		public int UserId { get; set; }
		public AppUser User { get; set; }
	}
}
