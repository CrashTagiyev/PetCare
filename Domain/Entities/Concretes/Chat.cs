using Domain.Entities.Abstracts;
using Domain.Identity;

namespace Domain.Entities.Concretes
{
	public class Chat : Entity
	{
		public int UserId { get; set; }
		public int VetId { get; set; }
        public string ChatName { get; set; }
        public DateTime? EndedAt { get; set; }

		// Navigation properties
		public AppUser User { get; set; }
		public AppUser Vet { get; set; }
		public ICollection<Message> Messages { get; set; }
	}
}
