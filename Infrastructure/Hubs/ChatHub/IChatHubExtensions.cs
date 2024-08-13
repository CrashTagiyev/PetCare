using Domain.DTOs.ReadDTO;
using Domain.Models.ChatHubModels;

namespace Infrastructure.Hubs.ChatHub
{
	public interface IChatHubExtensions
	{
		Task SendMessage(MessageReadDTO message);
		Task GetConnectedChatsMessages(List<MessageReadDTO> messages);
		Task SendNotification(NotificationModel notification);
		Task GetUsersNotifications(List<NotificationModel> notifications);
	}
}
