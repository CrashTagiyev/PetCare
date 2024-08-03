using Application.ServiceAbstracts;
using Domain.DTOs.ReadDTO;
using Domain.Models.ChatHubModels;
using Microsoft.AspNetCore.SignalR;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

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
			await Groups.AddToGroupAsync(Context.ConnectionId, connection.chatName);

			var connectedChatsMessage = await _hubService.GetChatsMessages(connection.chatName);

			await Clients.Group(connection.chatName).GetConnectedChatsMessages(connectedChatsMessage.ToList());
		}

		public async Task SendMessageToChat(SendMessageModel sendMessageModel)
		{
			await _hubService.SaveMessageToDb(sendMessageModel);
			var newMessage = new MessageReadDTO()
			{
				Content = sendMessageModel.message,
				SenderName = sendMessageModel.username,
				SentAt = DateTime.Now,
			};
			await Clients.Group(sendMessageModel.chatName).SendMessage(newMessage);
		}



	}
}
