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
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine(connection.username);
            Console.WriteLine(connection.chatName);
            Console.WriteLine("-----------------------------------------------");
            await _hubService.CreateChatAtDb(connection);
			await Groups.AddToGroupAsync(Context.ConnectionId, connection.chatName);

			var connectedChatsMessage = await _hubService.GetChatsMessages(connection.chatName);

			await Clients.Group(connection.chatName).GetConnectedChatsMessages(connectedChatsMessage.ToList());
		}

		public async Task SendMessageToChat(SendMessageModel sendMessageModel)
		{
			await _hubService.SaveMessageToDb(sendMessageModel);
			await Clients.Group(sendMessageModel.groupName).SendMessage(sendMessageModel.username, sendMessageModel.message, sendMessageModel.groupName);
		}



	}
}
