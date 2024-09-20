using System.Net;
using Application.ServiceAbstracts;
using AutoMapper;
using Domain.AbstractRepositories.EntityRepos.WriteRepos;
using Domain.DTOs.WriteDTO;
using Domain.Entities.Concretes;
using Microsoft.AspNetCore.Http.HttpResults;

namespace Infrastructure.InternalServices;

public class AdoptService: IAdoptService
{
    private readonly IAdoptionWriteRepository _adoptionWriteRepository;
    private readonly IMapper _mapper;


    public AdoptService(IAdoptionWriteRepository adoptionWriteRepository, IMapper mapper)
    {
        _adoptionWriteRepository = adoptionWriteRepository;
        _mapper = mapper;
    }

    public async Task<HttpStatusCode> CreateAdoptionAsync(AdoptionWriteDto adoptionWriteDto)
    {
        var adoption = _mapper.Map<Adoption>(adoptionWriteDto);
        await _adoptionWriteRepository.CreateAsync(adoption);

        return HttpStatusCode.OK;
    }

    public async Task<Adoption> HandleAdoptRequest(int adoptionId, bool response)
    {
        var result = await _adoptionWriteRepository.HandleAdoptRequest(adoptionId, response);
        return result;
    }
}