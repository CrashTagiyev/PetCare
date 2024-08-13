namespace Domain.DTOs.ReadDTO
{
	public class MessageReadDTO
	{
		public string SenderName { get; set; }
		public string Content { get; set; }
		public bool IsSeen { get; set; }
		public string CreatedTime { get; set; }
	}
}
