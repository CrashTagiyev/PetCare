using AutoMapper;
using Domain.DTOs.AdminPanelDTOs;
using Domain.DTOs.AdminPanelDTOs.AppUserControlDTOs;
using Domain.DTOs.AdminPanelDTOs.CompanyControlDTOs;
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

			CreateMap<CompanyUpdateAdminDTO, AppUser>()
				.ForMember(dest => dest.Id, options => options.Ignore());


		}
	}
}
