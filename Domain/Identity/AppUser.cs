using Domain.Entities.Abstracts;
using Domain.Entities.Concretes;
using Microsoft.AspNetCore.Identity;


namespace Domain.Identity
{
	public class AppUser : IdentityUser<int>,IBaseEntity
	{
		public string? Firstname { get; set; }
		public string? Lastname { get; set; }
		public DateTime? DateOfBirth { get; set; }
		public string? City { get; set; }
		public string? Address { get; set; }

		// Refresh Token properties
		public string? RefreshToken { get; set; }
		public DateTime? RefreshTokenExpireTime { get; set; }
		public DateTime? RefreshTokenCreateTime { get; set; } = DateTime.Now;

		//Base entity props
		public DateTime CreatedTime { get; set; }= DateTime.UtcNow;
		public DateTime LastUpdatedTime { get; set; }
		public bool IsDeleted { get; set; }
        public string? ProfileImageUrl { get; set; }

        //Navigation properties
        //Company
        public virtual ICollection<Shelter>? Shelters { get; set; }

		//App Users
		public ICollection<Donation>? Donations { get; set; }
		public ICollection<AcceptRequest>? AcceptRequests { get; set; }
		public ICollection<Adoption>? Adoptions { get; set; }

		//Chatting
		public ICollection<Chat> Chats { get; set; }
		public ICollection<Message> Messages { get; set; }

		//Notifications
		public ICollection<Notification> Notifications { get; set; }	

	}
}
