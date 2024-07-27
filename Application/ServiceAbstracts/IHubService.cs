using Domain.DTOs.ReadDTO;
using Domain.Models.ChatHubModels;

namespace Application.ServiceAbstracts
{
	public interface IHubService
	{
		Task CreateChatAtDb(UserConnection connection);
		Task SaveMessageToDb(SendMessageModel sendMessageModel);
		Task<ICollection<ChatReadDTO>?> GetUsersChats(string userName);
	}
}
