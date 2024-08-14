using Domain.Entities.Abstracts;
using Domain.Entities.Concretes;
using Microsoft.AspNetCore.Identity;


namespace Domain.Identity
{
	public class AppUser : IdentityUser<int>,IBaseEntity
	{
		public string Firstname { get; set; }
		public string Lastname { get; set; }
		public DateTime? DateOfBirth { get; set; }
		public string City { get; set; }
		public string Address { get; set; }

		// Refresh Token properties
		public string? RefreshToken { get; set; }
		public DateTime? RefreshTokenExpireTime { get; set; }
		public DateTime? RefreshTokenCreateTime { get; set; } = DateTime.Now;

		//Base entity props
		public DateTime CreatedTime { get; set; }= DateTime.UtcNow;
		public DateTime LastUpdatedTime { get; set; }
		public bool IsDeleted { get; set; }
        public string? ProfileImageUrl { get; set; }

		////Vet
		public int Likes { get; set; } = 0;
		public int Dislikes { get; set; } = 0;
		public string? About { get; set; }

		//Company
		public virtual ICollection<Shelter>? Shelters { get; set; }
		
		//App Users
		public virtual ICollection<Donation>? Donations { get; set; }
		public virtual ICollection<AcceptRequest>? AcceptRequests { get; set; }
		public virtual ICollection<Adoption>? Adoptions { get; set; }

        //Chatting between Vet  && User || Company
        public virtual ICollection<Chat> Chats { get; set; }
		public virtual ICollection<Message> Messages { get; set; }

		//Notifications
		public virtual ICollection<Notification> Notifications { get; set; }	

	}
}
