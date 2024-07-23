using Domain.Entities.Concretes;
using Domain.Identity;
using Domain.Models.ChatHubModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Persistance.Database;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Infrastructure.Hubs.ChatHub
{
	public class ChatHub : Hub<IChatHubExtensions>
	{
		private readonly PetCareDB _dbContext;
		private readonly UserManager<AppUser> _userManager;

		public ChatHub(PetCareDB dbContext, UserManager<AppUser> userManager)
		{
			_dbContext = dbContext;
			_userManager = userManager;
		}

		public async Task CreateConnection(UserConnection connection)
		{
			var splitGroupName = connection.groupname.Split('+');
			var reverseGroupName = string.Join("+", splitGroupName.Reverse());
			var isChatExist = await _dbContext.Chats.FirstOrDefaultAsync(c => c.ChatName == reverseGroupName || c.ChatName == connection.groupname);

			if (isChatExist is not null)
			{
				var users = await _userManager.GetUsersInRoleAsync("AppUser");
				var vets = await _userManager.GetUsersInRoleAsync("Vet");

				AppUser? user = users.FirstOrDefault(u => u.UserName!.Contains(splitGroupName[0])) ??
							   users.FirstOrDefault(u => u.UserName!.Contains(splitGroupName[1]));
				AppUser? vet = users.FirstOrDefault(u => u.UserName!.Contains(splitGroupName[1])) ??
							  users.FirstOrDefault(u => u.UserName!.Contains(splitGroupName[0]));

				if (user is not null && vet is not null && !_dbContext.Chats.Any(c => c.ChatName.Contains(splitGroupName[0]) && c.ChatName.Contains(splitGroupName[1])))
				{
					var newChat = new Chat
					{
						ChatName = connection.groupname,
						VetId = vet.Id,
						UserId = user.Id
					};
					await _dbContext.Chats.AddAsync(newChat);
					await _dbContext.SaveChangesAsync();
				}
			}

			await Groups.AddToGroupAsync(Context.ConnectionId, connection.groupname);
		}

		public async Task SendMessageToChat(SendMessageModel sendMessageModel)
		{
			var senderUser = await _dbContext.Users.FirstOrDefaultAsync(u => u.UserName!.Contains(sendMessageModel.username));
			if (senderUser is not null)
			{
				var splitGroupName =sendMessageModel.groupName.Split('+');
				var reverseGroupName = string.Join("+", splitGroupName.Reverse());
				var chat = await _dbContext.Chats.FirstOrDefaultAsync(c => c.ChatName.Contains(sendMessageModel.groupName) || c.ChatName.Contains(reverseGroupName));
				if (chat is not null)
				{
					await _dbContext.Messages.AddAsync(new Message
					{
						SenderId = senderUser.Id,
						Content = sendMessageModel.message,
						ChatId = chat.Id,
						SentAt = DateTime.Now,
					});
					await _dbContext.SaveChangesAsync();
				}
			}
			await Clients.Group(sendMessageModel.groupName).SendMessage(sendMessageModel.username, sendMessageModel.message, sendMessageModel.groupName);
		}



	}
}
