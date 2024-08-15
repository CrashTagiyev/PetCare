using Application.ServiceAbstracts;
using AutoMapper;
using Domain.AbstractRepositories.EntityRepos.ReadRepos;
using Domain.AbstractRepositories.EntityRepos.WriteRepos;
using Domain.AbstractRepositories.IdentityRepos;
using Domain.DTOs.ReadDTO;
using Domain.DTOs.WriteDTO;
using Domain.Entities.Concretes;
using Domain.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class RepoTestController : ControllerBase
	{
		private readonly RoleManager<IdentityRole<int>> _roleManager;
		private readonly IMapper _mapper;
		private readonly IBlobService _blobService;
		//User repos
		#region User repositories
		private readonly IAppUserWriteRepository _appUserWriteRepository;
		private readonly IAppUserReadRepository _appUserReadRepository;
		private readonly UserManager<AppUser> _userManager;
		#endregion

		//PetType repos
		#region PetType repositories

		private readonly IPetTypeReadRepository _petTypeReadRepository;
		private readonly IPetTypeWriteRepository _petTypeWriteRepository;

		#endregion

		//Breed repos
		#region Breed repositories
		private readonly IBreedReadRepository _breedReadRepository;
		private readonly IBreedWriteRepository _breedWriteRepository;
		#endregion

		//Pets repos
		#region Pet repositories

		private readonly IPetWriteRepository _petWriteRepository;
		private readonly IPetReadRepository _petReadRepository;

		#endregion


		//Shelter repos
		#region shelter repos
		private readonly IShelterReadRepository _shelterReadRepository;
		private readonly IShelterWriteRepository _shelterWriteRepository;
		#endregion

		//Location repos
		#region location repos
		private readonly ILocationReadRepository _locationReadRepository;
		private readonly ILocationWriteRepository _locationWriteRepository;
		#endregion

		public RepoTestController(IAppUserWriteRepository appUserWriteRepository, IAppUserReadRepository appUserReadRepository, UserManager<AppUser> userManager, IPetTypeWriteRepository petTypeWriteRepository, IPetTypeReadRepository petTypeReadRepository, IBreedWriteRepository bioWriteRepository, IBreedReadRepository bioReadRepository, IPetReadRepository petReadRepository, IPetWriteRepository petWriteRepository, IMapper mapper, ILocationReadRepository locationReadRepository, ILocationWriteRepository locationWriteRepository, IShelterReadRepository shelterReadRepository, IShelterWriteRepository shelterWriteRepository, RoleManager<IdentityRole<int>> roleManager, IBlobService blobService)
		{
			_appUserWriteRepository = appUserWriteRepository;
			_appUserReadRepository = appUserReadRepository;
			_userManager = userManager;
			_petTypeWriteRepository = petTypeWriteRepository;
			_petTypeReadRepository = petTypeReadRepository;
			_breedWriteRepository = bioWriteRepository;
			_breedReadRepository = bioReadRepository;
			_petReadRepository = petReadRepository;
			_petWriteRepository = petWriteRepository;
			_mapper = mapper;
			_locationReadRepository = locationReadRepository;
			_locationWriteRepository = locationWriteRepository;
			_shelterReadRepository = shelterReadRepository;
			_shelterWriteRepository = shelterWriteRepository;
			_roleManager = roleManager;
			_blobService = blobService;
		}

		//APpUser repo Test - checked
		#region AppUser repository tesing
		[HttpPost("[action]")]
		public async Task<IActionResult> AppUserCreate(string username, string email,string role)
		{
			var newUser = new AppUser()
			{
				UserName = username,
				Email = email,
				EmailConfirmed = true,
				Address="baku",
				City="baku"
			
			};
			await _appUserWriteRepository.CreateAsync(newUser);
			await _userManager.AddPasswordAsync(newUser, "123qweA@");
			await _userManager.AddToRoleAsync(newUser, role);

			return Ok();
		}

		[HttpPost("[action]")]
		public async Task<IActionResult> CreateRole(string roleName)
		{
			await _roleManager.CreateAsync(new IdentityRole<int> { Name = roleName });
			return Ok();
		}


		//App user Get by id - working 
		[HttpGet("[action]")]
		public async Task<IActionResult> AppUserGet(int id)
		{
			var user = await _appUserReadRepository.GetByIdAsync(id);

			return Ok(user);
		}

		//App user Get all - working 
		[HttpGet("[action]")]
		public async Task<IActionResult> AppUserGetAll()
		{
			var user = await _appUserReadRepository.GetAllAsync();

			return Ok(user);
		}

		[HttpGet("[action]")]
		public async Task<IActionResult> GetAllByRole([FromQuery] string roleName)
		{

            var users= await _userManager.GetUsersInRoleAsync(roleName);
			return Ok(users);
		}




		[HttpPut("[action]")]
		public async Task<IActionResult> AppUserUpdate(int id, string newUsername, string newEmail)
		{
			var user = await _appUserReadRepository.GetByIdAsync(id);
			if (user is not null)
			{
				user.UserName = newUsername;
				user.Email = newEmail;
				await _appUserWriteRepository.UpdateAsync(user);
				return Ok();
			}
			return NotFound("user did not found");
		}

		//App user delete by id - working 
		[HttpDelete("[action]")]
		public async Task<IActionResult> AppUserDeleteById(int id)
		{
			await _appUserWriteRepository.DeleteAsync(id);
			return Ok();
		}
		//--------------------------------------------------------------------------------------
		#endregion

		//PetType repo Test - checked
		#region PetType repository test
		[HttpPost("[action]")]
		public async Task<IActionResult> PetTypeCreate(string typeName)
		{
			var petType = new PetType() { TypeName = typeName };


			await _petTypeWriteRepository.CreateAsync(petType);
			return Ok();


		}

		[HttpGet("[action]")]
		public async Task<IActionResult> PetTypeGetAll()
		{
			var petTypes = await _petTypeReadRepository.GetAllAsync();
			return Ok(petTypes);

		}

		[HttpGet("[action]")]
		public async Task<IActionResult> PetTypeGetById(int id)
		{
			var petType = await _petTypeReadRepository.GetByIdAsync(id);
			return Ok(petType);

		}

		[HttpPut("[action]")]
		public async Task<IActionResult> PetTypeUpdate(int id, string newTypeName)
		{
			var petType = await _petTypeReadRepository.GetByIdAsync(id);
			if (petType is not null)
			{

				petType.TypeName = newTypeName;
				await _petTypeWriteRepository.UpdateAsync(petType);
				return Ok();

			}
			return NotFound();
		}
		[HttpDelete("[action]")]
		public async Task<IActionResult> PetTypeDelete(int id)
		{
			await _petTypeWriteRepository.DeleteAsync(id);
			return Ok();
		}
		#endregion

		//Breed tepo test - checked
		#region Breed repository test
		[HttpPost("[action]")]
		public async Task<IActionResult> BreedCreate(string breedName, int petTypeId)
		{
			var breed = new Breed() { BreedName = breedName, PetTypeId = petTypeId };


			await _breedWriteRepository.CreateAsync(breed);
			return Ok();


		}

		[HttpGet("[action]")]
		public async Task<IActionResult> BreedGetAll()
		{
			var breed = await _breedReadRepository.GetAllAsync();
			return Ok(breed);

		}

		[HttpGet("[action]")]
		public async Task<IActionResult> BreedGetById(int id)
		{
			var breed = await _breedReadRepository.GetByIdAsync(id);
			return Ok(breed);

		}

		[HttpPut("[action]")]
		public async Task<IActionResult> BreedUpdate(int id, string newBreedName)
		{
			var breed = await _breedReadRepository.GetByIdAsync(id);
			if (breed is not null)
			{

				breed.BreedName = newBreedName;
				await _breedWriteRepository.UpdateAsync(breed);
				return Ok();

			}
			return NotFound();
		}
		[HttpDelete("[action]")]
		public async Task<IActionResult> BreedDelete(int id)
		{
			await _breedWriteRepository.DeleteAsync(id);
			return Ok();
		}

		#endregion

		//BlobService test-
		[HttpPost("[action]")]
		public async Task<IActionResult> UploadImageToBlob(IFormFile file)
		{
			await _blobService.UploadImageFileAsync(file);
			return Ok();
		}

		[HttpPost("[action]")]
		public async Task<IActionResult> UploadImageыToBlob(IFormFileCollection files)
		{
			var Imageurls = await _blobService.UploadImageFileRangeAsync(files);
			return Ok(Imageurls);
		}


		//Location repo test -
		#region Location test
		[HttpPost("[action]")]
		public async Task<IActionResult> LocationCreate([FromBody] LocationWriteDto locationWriteDto)
		{
			var location = _mapper.Map<Location>(locationWriteDto);
			await _locationWriteRepository.CreateAsync(location);
			return Ok();
		}

		[HttpGet("[action]")]
		public async Task<IActionResult> LocationGet(int id)
		{
			var location = await _locationReadRepository.GetByIdAsync(id);
			var locationDTO = _mapper.Map<LocationReadDto>(location);

			return Ok(location);
		}
		#endregion

		#region Shelter repo test
		[HttpPost("[action]")]
		public async Task<IActionResult> ShelterCreate([FromBody] ShelterWriteDto shelterWriteDto)
		{
			try
			{
				var shelter = _mapper.Map<Shelter>(shelterWriteDto);
				await _shelterWriteRepository.CreateAsync(shelter);

				return Ok(shelter);
			}
			catch (Exception ex)
			{
				return Ok(ex.Message);
			}
		}

		[HttpGet("[action]")]
		public async Task<IActionResult> ShelterGet(int id)
		{
			var shelter = await _shelterReadRepository.GetByIdAsync(id);
			var shelterReadDTO = _mapper.Map<ShelterReadDto>(shelter);
			shelterReadDTO.Location = _mapper.Map<LocationReadDto>(shelter.Location);

			shelterReadDTO.Company = shelter!.Company.UserName!;
			return Ok(shelterReadDTO);
		}

		[HttpGet("[action]")]
		public async Task<IActionResult> ShelterGetAll()
		{
			var shelters = await _shelterReadRepository.GetAllAsync();
			return Ok(shelters);
		}
		#endregion

	}
}
