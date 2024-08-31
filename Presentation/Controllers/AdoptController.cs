using Application.ServiceAbstracts;
using Domain.DTOs.WriteDTO;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AdoptController: ControllerBase
{
    private readonly IAdoptService _adoptService;

    public AdoptController(IAdoptService adoptService)
    {
        _adoptService = adoptService;
    }

    [HttpPost("[action]")]
    public async Task<IActionResult> CreateAdoption([FromForm]AdoptionWriteDto adoptionWriteDto)
    {
        var result = await _adoptService.CreateAdoptionAsync(adoptionWriteDto);

        return Ok(result);
    }
}