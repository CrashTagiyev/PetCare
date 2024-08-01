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
	public class HubService(IChatWriteRepository chatWriteRepository, IChatReadRepository chatReadRepository, UserManager<AppUser> userManager, IMapper mapper, IMessageWriteRepository messageWriteRepository, IMessageReadRepository messageReadRepository) : IHubService
	{
		private readonly IChatWriteRepository _chatWriteRepository = chatWriteRepository;
		private readonly IChatReadRepository _chatReadRepository = chatReadRepository;
		private readonly IMessageWriteRepository _messageWriteRepository = messageWriteRepository;
		private readonly IMessageReadRepository _messageReadRepository = messageReadRepository;
		private readonly UserManager<AppUser> _userManager = userManager;
		private readonly IMapper _mapper = mapper;


		public async Task CreateChatAtDb(UserConnection connection)
		{
			var isChatExist = await _chatReadRepository.GetChatByNameAndReverseName(connection.chatName);

			if (isChatExist is null)
			{
				var users = await _userManager.GetUsersInRoleAsync("AppUser");
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

				var chat = await _chatReadRepository.GetChatByNameAndReverseName(sendMessageModel.groupName);
				if (chat is not null)
				{
					await _messageWriteRepository.CreateAsync(new Message
					{
						SenderId = senderUser.Id,
						Content = sendMessageModel.message,
						ChatId = chat.Id,
						SentAt = DateTime.Now,
					});
				}
			}
		}
		public async Task<ICollection<ChatReadDTO>?> GetUsersChats(string userName)
		{
			var chats = await _chatReadRepository.GetUserChats(userName);
			return chats.Select(c => new ChatReadDTO
			{
				ChatName = c.ChatName,
				AppUserName = c.User.UserName!,
				VetUserName = c.Vet.UserName!,

			}).ToList();
		}

		public async Task<ICollection<MessageReadDTO>> GetChatsMessages(string chatName)
		{
			var messages = await _messageReadRepository.GetMessagesByChatName(chatName);
			var messageDTOs = messages.Select(m => new MessageReadDTO
			{
				SentAt = m.SentAt,
				SenderName = m.Sender.UserName!,
				Content = m.Content
			}).ToList();
			return messageDTOs;
		}
	}
}
