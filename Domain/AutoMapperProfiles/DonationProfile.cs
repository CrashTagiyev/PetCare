using AutoMapper;
using Domain.DTOs.ReadDTO;
using Domain.DTOs.WriteDTO;
using Domain.Entities.Concretes;

namespace Domain.AutoMapperProfiles;

public class DonationProfile: Profile
{
    public DonationProfile()
    {
        // DonationReadDto ...
        CreateMap<Donation , DonationReadDto>();
        CreateMap<DonationReadDto, Donation>();
        
        // DonationWriteDto ...
        CreateMap<DonationWriteDto, Donation>();
        CreateMap<Donation, DonationWriteDto>();
    }
}