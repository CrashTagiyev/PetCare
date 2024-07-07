using AutoMapper;
using Domain.Identity;
using Domain.Models.AuthModels.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.AutoMapperProfiles
{
	public class AppUserProfile:Profile
	{
        public AppUserProfile()
        {
            CreateMap<RegisterRequest, AppUser>();
        }
    }
}
