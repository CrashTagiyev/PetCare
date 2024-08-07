using Domain.DTOs.ReadDTO;
using Domain.Models.ChatHubModels;

namespace Application.ServiceAbstracts
{
	public interface IHubService
	{
		Task CreateChatAtDb(UserConnection connection);
		Task SaveMessageToDb(SendMessageModel sendMessageModel);
		Task SaveNotificationToDb(NotificationModel notification);
		Task<ICollection<ChatReadDTO>> GetUsersChats(string userName);
		Task<ICollection<MessageReadDTO>> GetChatsMessages(string username,string chatName);
		Task<ICollection<NotificationModel>> GetUsersNotifications(string userName);
		Task<string> GetRecieverNameByGroupName(string groupName, string senderName);
	
	}
}
