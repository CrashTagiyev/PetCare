using Application.ServiceAbstracts;
using Domain.DTOs.ReadDTO;
using Domain.Models.ChatHubModels;
using Microsoft.AspNetCore.SignalR;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Infrastructure.Hubs.ChatHub
{
	public class ChatHub : Hub<IChatHubExtensions>
	{
		private static Dictionary<string, List<string>> _userConnections = new();
		private readonly IHubService _hubService;

		public ChatHub(IHubService hubService)
		{
			_hubService = hubService;
		}

		public async Task CreateChatConnection(UserConnection connection)
		{
						
			if (!_userConnections.ContainsKey(connection.username))
			{
				_userConnections[connection.username] = new List<string>();
			}
			_userConnections[connection.username].Add(Context.ConnectionId);

			await _hubService.CreateChatAtDb(connection);
			await Groups.AddToGroupAsync(Context.ConnectionId, connection.chatName);
			var connectedChatsMessage = await _hubService.GetChatsMessages(connection.username, connection.chatName);
			await Clients.Group(connection.chatName).GetConnectedChatsMessages(connectedChatsMessage.ToList());
		}


		public async Task CreateNotificationConnection(string username)
		{
			await Groups.AddToGroupAsync(Context.ConnectionId, username + "Notifications");
			var usersNotifications = await _hubService.GetUsersNotifications(username);
			await Clients.Group(username + "Notifications").GetUsersNotifications(usersNotifications.ToList());
		}

		public override Task OnDisconnectedAsync(Exception? exception)
		{
			foreach (var userConnections in _userConnections)
			{
				if (userConnections.Value.Contains(Context.ConnectionId))
				{
					userConnections.Value.Remove(Context.ConnectionId);
					if (userConnections.Value.Count == 0)
					{
						_userConnections.Remove(userConnections.Key);
					}
					break;
				}
			}
			return base.OnDisconnectedAsync(exception);
		}

		public static bool IsUserConnected(string username)
		{
			return _userConnections.ContainsKey(username) && _userConnections[username].Count > 0;
		}

		public async Task SendMessageToChat(SendMessageModel sendMessageModel)
		{
			var newMessage = new MessageReadDTO()
			{
				Content = sendMessageModel.message,
				SenderName = sendMessageModel.username,
				CreatedTime = DateTime.Now.ToShortDateString(),
			};

			var receiverName = await _hubService.GetRecieverNameByGroupName(sendMessageModel.chatName, sendMessageModel.username);
			if (IsUserConnected(receiverName))
			{

				newMessage.IsSeen = true;
				await Clients.Group(sendMessageModel.chatName).SendMessage(newMessage);

			}
			else
			{

				newMessage.IsSeen = false;
				await Clients.Group(sendMessageModel.chatName).SendMessage(newMessage);

				var newNotification = new NotificationModel()
				{
					SenderUserName = sendMessageModel.username,
					Content= $"You have receive a new message:{sendMessageModel.message}",
				};
				await Clients.Group(receiverName + "Notifications").SendNotification(newNotification);
				newNotification.SenderUserName = sendMessageModel.username;
				newNotification.ReceiverUserName=receiverName;
				await _hubService.SaveNotificationToDb(newNotification);
			}
			await _hubService.SaveMessageToDb(sendMessageModel);
		}
	}
}
