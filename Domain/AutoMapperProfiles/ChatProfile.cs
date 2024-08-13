using AutoMapper;
using Domain.DTOs.ReadDTO;
using Domain.Entities.Concretes;
using Domain.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.AutoMapperProfiles
{
	public class ChatProfile : Profile
	{
		public ChatProfile()
		{
			CreateMap<Chat, ChatReadDTO>();
		}
	}
}
