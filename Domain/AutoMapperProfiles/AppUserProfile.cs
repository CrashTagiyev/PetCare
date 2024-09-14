using AutoMapper;
using Domain.DTOs.ReadDTO.AdminPanelDTOs;
using Domain.DTOs.ReadDTO.AdminPanelDTOs.AppUserControlDTOs;
using Domain.DTOs.ReadDTO.IdentityDTOs;
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
            //Auth
            CreateMap<RegisterRequest, AppUser>();
            CreateMap<RegisterCompanyRequest, AppUser>();
			CreateMap<RegisterVetRequest, AppUser>();
			
			// User
			CreateMap<AppUser, UserDto>();
			CreateMap<UserDto, AppUser>();

            //Vet
            CreateMap<AppUser,VetInfoDTO>();

           //Company
           CreateMap<AppUser,CompanyProfileReadDTO>(); 


            //Admin panel
            CreateMap<AppUser, AppUserReadAdminDTO>();
            CreateMap<AppUser, CompanyReadAdminDTO>();
            CreateMap<AppUser, VetReadAdminDTO>();
            CreateMap<AppUserUpdateAdminDTO, AppUser>()
                .ForMember(dest => dest.Id, options => options.Ignore());
		}
    }
}
