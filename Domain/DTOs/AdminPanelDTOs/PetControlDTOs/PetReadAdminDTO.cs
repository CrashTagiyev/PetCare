﻿using Domain.DTOs.ReadDTO;
using Domain.Enums;

namespace Domain.DTOs.AdminPanelDTOs.PetControlDTOs
{
	public class PetReadAdminDTO
	{
		public int Id { get; set; }
		public string? PetName { get; set; }
		public string? Description { get; set; }
		public string? Size { get; set; }
		public short Age { get; set; }
		public Gender? Gender { get; set; }
		public string[]? ImageUrls { get; set; }
		public bool IsAdopted { get; set; }
		public string Health { get; set; }
		public decimal Weight { get; set; }
		public DateTime? CreatedTime { get; set; }

		public PetTypeReadDto PetType { get; set; }
		public ShelterReadDto Shelter { get; set; }
		public BreedReadDto Breed { get; set; }
	}
}
