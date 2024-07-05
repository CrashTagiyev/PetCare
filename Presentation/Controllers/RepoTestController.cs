using Domain.AbstractRepositories.EntityRepos.ReadRepos;
using Domain.AbstractRepositories.EntityRepos.WriteRepos;
using Domain.AbstractRepositories.IdentityRepos;
using Domain.Entities.Concretes;
using Domain.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class RepoTestController : ControllerBase
	{
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

		public RepoTestController(IAppUserWriteRepository appUserWriteRepository, IAppUserReadRepository appUserReadRepository, UserManager<AppUser> userManager, IPetTypeWriteRepository petTypeWriteRepository, IPetTypeReadRepository petTypeReadRepository, IBreedWriteRepository bioWriteRepository, IBreedReadRepository bioReadRepository)
		{
			_appUserWriteRepository = appUserWriteRepository;
			_appUserReadRepository = appUserReadRepository;
			_userManager = userManager;
			_petTypeWriteRepository = petTypeWriteRepository;
			_petTypeReadRepository = petTypeReadRepository;
			_breedWriteRepository = bioWriteRepository;
			_breedReadRepository = bioReadRepository;
		}

		//APpUser repo Test - checked
		#region AppUser repository tesing
		[HttpPost("[action]")]
		public async Task<IActionResult> AppUserCreate(string username, string email)
		{
			var newUser = new AppUser()
			{
				UserName = username,
				Email = email,
			};
			await _appUserWriteRepository.CreateAsync(newUser);

			await _userManager.AddPasswordAsync(newUser, "123qweA@");
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
		public async Task<IActionResult> BreedCreate(string breedName,int petTypeId)
		{
			var breed = new Breed() { BreedName = breedName ,PetTypeId=petTypeId};


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

	   //
	}
}
