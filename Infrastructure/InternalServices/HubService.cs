using Application.ServiceAbstracts;
using AutoMapper;
using Domain.AbstractRepositories.EntityRepos.ReadRepos;
using Domain.AbstractRepositories.EntityRepos.WriteRepos;
using Domain.DTOs.ReadDTO;
using Domain.Entities.Concretes;
using Domain.Identity;
using Domain.Models.ChatHubModels;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.InternalServices
{
	public class HubService : IHubService
	{
		private readonly IChatWriteRepository _chatWriteRepository;
		private readonly IChatReadRepository _chatReadRepository;

		private readonly IMessageWriteRepository _messageWriteRepository;
		private readonly IMessageReadRepository _messageReadRepository;

		private readonly INotificationWriteRepository _notificationWriteRepository;
		private readonly INotificationReadRepository _notificationReadRepository;

		private readonly UserManager<AppUser> _userManager;
		private readonly IMapper _mapper;

		public HubService(IChatWriteRepository chatWriteRepository, IChatReadRepository chatReadRepository, UserManager<AppUser> userManager, IMapper mapper, IMessageWriteRepository messageWriteRepository, IMessageReadRepository messageReadRepository, INotificationReadRepository notificationReadRepository, INotificationWriteRepository notificationWriteRepository)
		{
			_chatWriteRepository = chatWriteRepository;
			_chatReadRepository = chatReadRepository;
			_messageWriteRepository = messageWriteRepository;
			_messageReadRepository = messageReadRepository;
			_userManager = userManager;
			_mapper = mapper;
			_notificationReadRepository = notificationReadRepository;
			_notificationWriteRepository = notificationWriteRepository;
		}

		public async Task CreateChatAtDb(UserConnection connection)
		{
			var isChatExist = await _chatReadRepository.GetChatByNameAndReverseName(connection.chatName);

			if (isChatExist is null)
			{
				var users = await _userManager.GetUsersInRoleAsync("User");
				var vets = await _userManager.GetUsersInRoleAsync("Vet");


				var splitGroupName = connection.chatName.Split('+');

				AppUser? user = users.FirstOrDefault(u => u.UserName!.Contains(splitGroupName[0])) ??
								users.FirstOrDefault(u => u.UserName!.Contains(splitGroupName[1]));

				AppUser? vet = vets.FirstOrDefault(u => u.UserName!.Contains(splitGroupName[1])) ??
							   vets.FirstOrDefault(u => u.UserName!.Contains(splitGroupName[0]));

				if (user is not null && vet is not null)
				{
					var newChat = new Chat
					{
						ChatName = connection.chatName,
						VetId = vet.Id,
						UserId = user.Id
					};
					await _chatWriteRepository.CreateAsync(newChat);
				}

			}
		}
		public async Task SaveMessageToDb(SendMessageModel sendMessageModel)
		{
			var senderUser = await _userManager.FindByNameAsync(sendMessageModel.username);
			if (senderUser is not null)
			{

				var chat = await _chatReadRepository.GetChatByNameAndReverseName(sendMessageModel.chatName);
				if (chat is not null)
				{
					await _messageWriteRepository.CreateAsync(new Message
					{
						SenderId = senderUser.Id,
						Content = sendMessageModel.message,
						ChatId = chat.Id,
						IsSeen = false
					});
				}
			}
		}
		public async Task<ICollection<ChatReadDTO>> GetUsersChats(string userName)
		{
			var chats = await _chatReadRepository.GetUserChats(userName);
			return chats.Select(c => new ChatReadDTO
			{
				ChatName = c.ChatName,
				AppUserName = c.User.UserName!,
				VetUserName = c.Vet.UserName!,

			}).ToList();
		}
		public async Task<ICollection<MessageReadDTO>> GetChatsMessages(string username, string chatName)
		{
			var messages = await _messageReadRepository.GetMessagesByChatName(chatName);

			foreach (var message in messages)
			{
				if (message.Sender.UserName != username)
				{
					message.IsSeen = true;
					await _messageWriteRepository.UpdateAsync(message);
				}
			};

			var messageDTOs = messages.Select(m => new MessageReadDTO
			{
				CreatedTime = m.CreatedTime.ToShortDateString() +" " + m.CreatedTime.ToShortTimeString(),
				SenderName = m.Sender.UserName!,
				Content = m.Content,
				IsSeen = m.IsSeen,
			}).ToList();


			return messageDTOs;
		}

		public async Task<string> GetRecieverNameByGroupName(string groupName, string senderName)
		{
			var splitGroupName = groupName.Split('+');
			var sendedToName = splitGroupName.FirstOrDefault(un => !un.StartsWith(senderName));
			return sendedToName!;
		}

		public async Task SaveNotificationToDb(NotificationModel notification)
		{
			var recieverUser = await _userManager.FindByNameAsync(notification.ReceiverUserName);
			if (recieverUser is not null)
			{

				var newNotification = new Notification()
				{
					Content = notification.Content,
					SenderUserName = notification.SenderUserName,
					ReceiverUserName = notification.ReceiverUserName,
					UserId= recieverUser.Id
				};

				await _notificationWriteRepository.CreateAsync(newNotification);
				
			}

		}

		public async Task<ICollection<NotificationModel>> GetUsersNotifications(string userName)
		{
			var notifications=await _notificationReadRepository.GetNotificationsByUsername(userName);
			return notifications.Select(n => new NotificationModel()
			{
				Content = n.Content,
				SenderUserName = n.SenderUserName,
				SendedAt=n.CreatedTime.ToShortDateString() + " " +  n.CreatedTime.ToShortTimeString(),
				
			}).ToList();
		}
	}
}
