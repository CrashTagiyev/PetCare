using Domain.DTOs.ReadDTO;

namespace Infrastructure.Hubs.ChatHub
{
	public interface IChatHubExtensions
	{
		Task SendMessage(string username, string message, string groupName);
		Task GetConnectedChatsMessages(List<MessageReadDTO> messages);
	}
}
