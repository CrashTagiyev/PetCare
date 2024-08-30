using Domain.Enums;

namespace Domain.Models.EntityModels
{
	public class PetFilterModel
	{
		public bool IsAll { get; set; } 
		public string? PetName { get; set; }
		public string? Size { get; set; }
		public short? MinAge { get; set; }
		public short? MaxAge { get; set; }
		public Gender? Gender { get; set; }
		public decimal? MinWeight { get; set; }
		public decimal? MaxWeight { get; set; }
		public int? BreedId { get; set; }
		public int? PetTypeId { get; set; }
		public int PageNumber { get; set; }
		public int PageSize { get; set; }
    }
}
