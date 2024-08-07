

namespace Domain.Models.ChatHubModels
{
	public class SendMessageModel
	{
		public string username { get; set; }
		public string message { get; set; }
		public string chatName { get; set; }
		public bool isSeen { get; set; }
	}
}
