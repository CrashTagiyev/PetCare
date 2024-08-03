using Domain.DTOs.ReadDTO;

namespace Infrastructure.Hubs.ChatHub
{
	public interface IChatHubExtensions
	{
		Task SendMessage(MessageReadDTO message);
		Task GetConnectedChatsMessages(List<MessageReadDTO> messages);
	}
}
