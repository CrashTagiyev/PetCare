using Domain.AbstractRepositories.EntityRepos.GenericRepos;
using Domain.DTOs.ReadDTO;
using Domain.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.AbstractRepositories.EntityRepos.ReadRepos
{
	public interface IChatReadRepository:IGenericReadRepository<Chat>
	{
		Task<Chat?> GetChatByChatName(string chatName);
		Task<Chat?> GetChatByNameAndReverseName(string chatName);
		Task<ICollection<Chat>> GetUserChats(string userName);
		
	}
}
