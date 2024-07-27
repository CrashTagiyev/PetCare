using Application.ServiceAbstracts;
using Domain.Models.ChatHubModels;
using Microsoft.AspNetCore.SignalR;

namespace Infrastructure.Hubs.ChatHub
{
	public class ChatHub : Hub<IChatHubExtensions>
	{
		private readonly IHubService _hubService;
		public ChatHub(IHubService hubService)
		{
			_hubService = hubService;
		}

		public async Task CreateConnection(UserConnection connection)
		{
			await _hubService.CreateChatAtDb(connection);
			await Groups.AddToGroupAsync(Context.ConnectionId, connection.groupname);
			await Clients.Group(connection.groupname).GetConnectedChatsMessages(connection.groupname);
		}

		public async Task SendMessageToChat(SendMessageModel sendMessageModel)
		{
			await _hubService.SaveMessageToDb(sendMessageModel);
			await Clients.Group(sendMessageModel.groupName).SendMessage(sendMessageModel.username, sendMessageModel.message, sendMessageModel.groupName);
		}



	}
}
