using AutoMapper;
using Domain.DTOs.ReadDTO;
using Domain.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.AutoMapperProfiles
{
	internal class PetAutoMapper:Profile
	{
        public PetAutoMapper()
        {
            CreateMap<PetReadDto, Pet>();
        }
    }
}
