using Domain.Entities.Concretes;
using Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Persistance.Configurations
{
	internal class PetConfig : IEntityTypeConfiguration<Pet>
	{
		public void Configure(EntityTypeBuilder<Pet> builder)
		{
			//Relations
			builder.HasOne(p => p.Shelter)
				.WithMany(sb => sb.Pets)
				.HasForeignKey(p => p.ShelterId).OnDelete(DeleteBehavior.Cascade);

			builder.HasOne(p => p.PetType)
				.WithMany(pt => pt.Pets)
				.HasForeignKey(p => p.PetTypeId).OnDelete(DeleteBehavior.SetNull);
			
			builder.HasOne(p => p.Breed)
				.WithMany(b => b.Pets)
				.HasForeignKey(p => p.PetTypeId).OnDelete(DeleteBehavior.SetNull);

			builder.HasMany(p => p.Adoptions)
				.WithOne(a => a.Pet)
				.OnDelete(DeleteBehavior.Cascade);

			//Properties
			builder.Property(p => p.Age).IsRequired();
			builder.Property(p => p.Gender).IsRequired();
			builder.Property(p => p.PetName).IsRequired();
			builder.Property(p => p.Description).IsRequired();
			builder.Property(p => p.Age).IsRequired();
			builder.Property(p => p.Health).IsRequired();
			builder.Property(p => p.ShelterId).IsRequired();

			//seed datas
			var random = new Random();
			builder.HasData(
			// Dogs
		   new Pet { Id = 1, PetName = "Buddy", CreatedTime = DateTime.Now.AddMonths(-random.Next(1, 12)), Description = "Friendly Labrador Retriever", Size = "Large", Age = 3, Gender = Gender.Male, ImageUrls = new string[] { "https://images.unsplash.com/photo-1574158622682-e40e69881006", "https://images.unsplash.com/photo-1583511656127-8a22f6e9f018" }, IsAdopted = false, Health = "Healthy", Weight = 30.5m, BreedId = 1, PetTypeId = 2, ShelterId = 1026 },
		   new Pet { Id = 2, PetName = "Bella", CreatedTime = DateTime.Now.AddMonths(-random.Next(1, 12)), Description = "Energetic Beagle", Size = "Medium", Age = 2, Gender = Gender.Female, ImageUrls = new string[] { "https://images.unsplash.com/photo-1560807707-8cc77767d783", "https://images.unsplash.com/photo-1560807707-8cc77767d783" }, IsAdopted = false, Health = "Healthy", Weight = 10.2m, BreedId = 2, PetTypeId = 1, ShelterId = 1026 },
		   new Pet { Id = 3, PetName = "Max", CreatedTime = DateTime.Now.AddMonths(-random.Next(1, 12)), Description = "Loyal German Shepherd", Size = "Large", Age = 5, Gender = Gender.Male, ImageUrls = new string[] { "https://images.unsplash.com/photo-1560807707-8cc77767d783", "https://images.unsplash.com/photo-1601758124199-0a4b30c13d8e" }, IsAdopted = true, Health = "Healthy", Weight = 40.8m, BreedId = 3, PetTypeId = 1, ShelterId = 1026 },
		   new Pet { Id = 4, PetName = "Lucy", CreatedTime = DateTime.Now.AddMonths(-random.Next(1, 12)), Description = "Clever Border Collie", Size = "Medium", Age = 4, Gender = Gender.Female, ImageUrls = new string[] { "https://images.unsplash.com/photo-1579362242788-7d8d553f7d82", "https://images.unsplash.com/photo-1593137318309-7d0bdc18f9c3" }, IsAdopted = false, Health = "Healthy", Weight = 18.7m, BreedId = 4, PetTypeId = 1, ShelterId = 1026 },
		   new Pet { Id = 5, PetName = "Charlie", CreatedTime = DateTime.Now.AddMonths(-random.Next(1, 12)), Description = "Playful Golden Retriever", Size = "Large", Age = 2, Gender = Gender.Male, ImageUrls = new string[] { "https://images.unsplash.com/photo-1557302985-673a2c6c8c83", "https://images.unsplash.com/photo-1596495577886-d920f15eb45d" }, IsAdopted = true, Health = "Healthy", Weight = 28.3m, BreedId = 5, PetTypeId = 1, ShelterId = 1026 },

		   // Cats
		   new Pet { Id = 6, PetName = "Mittens", CreatedTime = DateTime.Now.AddMonths(-random.Next(1, 12)), Description = "Playful Maine Coon", Size = "Large", Age = 2, Gender = Gender.Female, ImageUrls = new string[] { "https://images.unsplash.com/photo-1585791325888-0fc79fae1484", "https://images.unsplash.com/photo-1570816118443-e11a95c3f168" }, IsAdopted = true, Health = "Healthy", Weight = 10.2m, BreedId = 6, PetTypeId = 2, ShelterId = 1026 },
		   new Pet { Id = 7, PetName = "Whiskers", CreatedTime = DateTime.Now.AddMonths(-random.Next(1, 12)), Description = "Curious Siamese", Size = "Medium", Age = 4, Gender = Gender.Male, ImageUrls = new string[] { "https://images.unsplash.com/photo-1560807707-8cc77767d783", "https://images.unsplash.com/photo-1584358147545-7fd7b772d2e8" }, IsAdopted = false, Health = "Healthy", Weight = 7.8m, BreedId = 7, PetTypeId = 2, ShelterId = 1026 },
		   new Pet { Id = 8, PetName = "Shadow", CreatedTime = DateTime.Now.AddMonths(-random.Next(1, 12)), Description = "Silent Russian Blue", Size = "Medium", Age = 3, Gender = Gender.Male, ImageUrls = new string[] { "https://images.unsplash.com/photo-1592194996308-7b19e0c4730b", "https://images.unsplash.com/photo-1593137318309-7d0bdc18f9c3" }, IsAdopted = true, Health = "Healthy", Weight = 8.5m, BreedId = 8, PetTypeId = 2, ShelterId = 1026 },
		   new Pet { Id = 9, PetName = "Luna", CreatedTime = DateTime.Now.AddMonths(-random.Next(1, 12)), Description = "Graceful Persian", Size = "Small", Age = 2, Gender = Gender.Female, ImageUrls = new string[] { "https://images.unsplash.com/photo-1583511656127-8a22f6e9f018", "https://images.unsplash.com/photo-1560807707-8cc77767d783" }, IsAdopted = false, Health = "Healthy", Weight = 5.3m, BreedId = 9, PetTypeId = 2, ShelterId = 1026 },
		   new Pet { Id = 10, PetName = "Simba", CreatedTime = DateTime.Now.AddMonths(-random.Next(1, 12)), Description = "Adventurous Bengal", Size = "Large", Age = 3, Gender = Gender.Male, ImageUrls = new string[] { "https://images.unsplash.com/photo-1560807707-8cc77767d783", "https://images.unsplash.com/photo-1601758124199-0a4b30c13d8e" }, IsAdopted = false, Health = "Healthy", Weight = 9.2m, BreedId = 10, PetTypeId = 2, ShelterId = 1026 },

		   // Birds
		   new Pet { Id = 11, PetName = "Tweety", CreatedTime = DateTime.Now.AddMonths(-random.Next(1, 12)), Description = "Chirpy Canary", Size = "Small", Age = 1, Gender = Gender.Female, ImageUrls = new string[] { "https://images.unsplash.com/photo-1558981289-42a1e2b2133e", "https://images.unsplash.com/photo-1560807707-8cc77767d783" }, IsAdopted = false, Health = "Healthy", Weight = 0.05m, BreedId = 11, PetTypeId = 3, ShelterId = 1026 },
		   new Pet { Id = 12, PetName = "Polly", CreatedTime = DateTime.Now.AddMonths(-random.Next(1, 12)), Description = "Talkative Parrot", Size = "Medium", Age = 5, Gender = Gender.Female, ImageUrls = new string[] { "https://images.unsplash.com/photo-1507611097612-5ff4d04e4b7e", "https://images.unsplash.com/photo-1508546293063-3094b6a13db5" }, IsAdopted = false, Health = "Healthy", Weight = 0.9m, BreedId = 12, PetTypeId = 3, ShelterId = 1026 },
		   new Pet { Id = 13, PetName = "Sky", CreatedTime = DateTime.Now.AddMonths(-random.Next(1, 12)), Description = "Graceful Cockatiel", Size = "Small", Age = 2, Gender = Gender.Male, ImageUrls = new string[] { "https://images.unsplash.com/photo-1560807707-8cc77767d783", "https://images.unsplash.com/photo-1558981289-42a1e2b2133e" }, IsAdopted = true, Health = "Healthy", Weight = 0.12m, BreedId = 13, PetTypeId = 3, ShelterId = 1026 },
		   new Pet { Id = 14, PetName = "Kiwi", CreatedTime = DateTime.Now.AddMonths(-random.Next(1, 12)), Description = "Colorful Parakeet", Size = "Small", Age = 3, Gender = Gender.Female, ImageUrls = new string[] { "https://images.unsplash.com/photo-1508610048659-a06d45f8a1a5", "https://images.unsplash.com/photo-1558981289-42a1e2b2133e" }, IsAdopted = false, Health = "Healthy", Weight = 0.06m, BreedId = 14, PetTypeId = 3, ShelterId = 1026 },
		   new Pet { Id = 15, PetName = "Coco", CreatedTime = DateTime.Now.AddMonths(-random.Next(1, 12)), Description = "Clever African Grey", Size = "Medium", Age = 4, Gender = Gender.Female, ImageUrls = new string[] { "https://images.unsplash.com/photo-1558981289-42a1e2b2133e", "https://images.unsplash.com/photo-1508546293063-3094b6a13db5" }, IsAdopted = true, Health = "Healthy", Weight = 0.45m, BreedId = 15, PetTypeId = 3, ShelterId = 1025 },

		   // Reptiles
		   new Pet { Id = 16, PetName = "Spike", CreatedTime = DateTime.Now.AddMonths(-random.Next(1, 12)), Description = "Spiky Bearded Dragon", Size = "Medium", Age = 4, Gender = Gender.Male, ImageUrls = new string[] { "https://images.unsplash.com/photo-1599945863043-c972ca05f8d0", "https://images.unsplash.com/photo-1560807707-8cc77767d783" }, IsAdopted = false, Health = "Healthy", Weight = 1.1m, BreedId = 16, PetTypeId = 4, ShelterId = 1026 },
		   new Pet { Id = 17, PetName = "Slinky", CreatedTime = DateTime.Now.AddMonths(-random.Next(1, 12)), Description = "Stealthy Corn Snake", Size = "Small", Age = 2, Gender = Gender.Male, ImageUrls = new string[] { "https://images.unsplash.com/photo-1587137112204-ff2af20e59d5", "https://images.unsplash.com/photo-1560807707-8cc77767d783" }, IsAdopted = false, Health = "Healthy", Weight = 0.3m, BreedId = 17, PetTypeId = 4, ShelterId = 1026 },
		   new Pet { Id = 18, PetName = "Gizmo", CreatedTime = DateTime.Now.AddMonths(-random.Next(1, 12)), Description = "Agile Gecko", Size = "Small", Age = 3, Gender = Gender.Female, ImageUrls = new string[] { "https://images.unsplash.com/photo-1593137318309-7d0bdc18f9c3", "https://images.unsplash.com/photo-1587137112204-ff2af20e59d5" }, IsAdopted = false, Health = "Healthy", Weight = 0.07m, BreedId = 18, PetTypeId = 4, ShelterId = 1026 },

		   // Small Mammals
		   new Pet { Id = 19, PetName = "Nibbles", CreatedTime = DateTime.Now.AddMonths(-random.Next(1, 12)), Description = "Curious Hamster", Size = "Small", Age = 1, Gender = Gender.Male, ImageUrls = new string[] { "https://images.unsplash.com/photo-1550807012-514e38ec9ad4", "https://images.unsplash.com/photo-1558981289-42a1e2b2133e" }, IsAdopted = true, Health = "Healthy", Weight = 0.03m, BreedId = 19, PetTypeId = 5, ShelterId = 1026 },
		   new Pet { Id = 20, PetName = "Fuzzy", CreatedTime = DateTime.Now.AddMonths(-random.Next(1, 12)), Description = "Fluffy Guinea Pig", Size = "Small", Age = 2, Gender = Gender.Female, ImageUrls = new string[] { "https://images.unsplash.com/photo-1550807012-514e38ec9ad4", "https://images.unsplash.com/photo-1558981289-42a1e2b2133e" }, IsAdopted = false, Health = "Healthy", Weight = 1.2m, BreedId = 20, PetTypeId = 5, ShelterId = 1026 },
		   new Pet { Id = 21, PetName = "Pip", CreatedTime = DateTime.Now.AddMonths(-random.Next(1, 12)), Description = "Playful Rabbit", Size = "Small", Age = 3, Gender = Gender.Male, ImageUrls = new string[] { "https://images.unsplash.com/photo-1550807012-514e38ec9ad4", "https://images.unsplash.com/photo-1560807707-8cc77767d783" }, IsAdopted = false, Health = "Healthy", Weight = 2.5m, BreedId = 21, PetTypeId = 5, ShelterId = 1026 },

		   // Exotic Pets
		   new Pet { Id = 22, PetName = "Chester", CreatedTime = DateTime.Now.AddMonths(-random.Next(1, 12)), Description = "Charming Chinchilla", Size = "Small", Age = 3, Gender = Gender.Male, ImageUrls = new string[] { "https://images.unsplash.com/photo-1550807012-514e38ec9ad4", "https://images.unsplash.com/photo-1558981289-42a1e2b2133e" }, IsAdopted = false, Health = "Healthy", Weight = 0.6m, BreedId = 22, PetTypeId = 6, ShelterId = 1026 },
		   new Pet { Id = 23, PetName = "Zara", CreatedTime = DateTime.Now.AddMonths(-random.Next(1, 12)), Description = "Lively Sugar Glider", Size = "Small", Age = 2, Gender = Gender.Female, ImageUrls = new string[] { "https://images.unsplash.com/photo-1550807012-514e38ec9ad4", "https://images.unsplash.com/photo-1558981289-42a1e2b2133e" }, IsAdopted = false, Health = "Healthy", Weight = 0.1m, BreedId = 23, PetTypeId = 6, ShelterId = 1026 },
		   new Pet { Id = 24, PetName = "Spike", CreatedTime = DateTime.Now.AddMonths(-random.Next(1, 12)), Description = "Spiky Hedgehog", Size = "Small", Age = 2, Gender = Gender.Male, ImageUrls = new string[] { "https://images.unsplash.com/photo-1550807012-514e38ec9ad4", "https://images.unsplash.com/photo-1558981289-42a1e2b2133e" }, IsAdopted = true, Health = "Healthy", Weight = 0.4m, BreedId = 24, PetTypeId = 6, ShelterId = 1026 },
		   new Pet { Id = 25, PetName = "Chinchy", CreatedTime = DateTime.Now.AddMonths(-random.Next(1, 12)), Description = "Soft Chinchilla", Size = "Small", Age = 4, Gender = Gender.Male, ImageUrls = new string[] { "url49.jpg", "url50.jpg" }, IsAdopted = true, Health = "Healthy", Weight = 0.6m, BreedId = 25, PetTypeId = 5, ShelterId = 1024 },

		   // Exotic Pets
		   new Pet { Id = 26, PetName = "Bubbles", CreatedTime = DateTime.Now.AddMonths(-random.Next(1, 12)), Description = "Colorful Betta Fish", Size = "Small", Age = 1, Gender = Gender.Male, ImageUrls = new string[] { "url51.jpg", "url52.jpg" }, IsAdopted = false, Health = "Healthy", Weight = 0.02m, BreedId = 26, PetTypeId = 6, ShelterId = 1024 },
		   new Pet { Id = 27, PetName = "Frodo", CreatedTime = DateTime.Now.AddMonths(-random.Next(1, 12)), Description = "Tiny Frog", Size = "Small", Age = 2, Gender = Gender.Female, ImageUrls = new string[] { "url53.jpg", "url54.jpg" }, IsAdopted = false, Health = "Healthy", Weight = 0.05m, BreedId = 27, PetTypeId = 6, ShelterId = 1024 },
		   new Pet { Id = 28, PetName = "Spidey", CreatedTime = DateTime.Now.AddMonths(-random.Next(1, 12)), Description = "Creepy Tarantula", Size = "Small", Age = 3, Gender = Gender.Female, ImageUrls = new string[] { "url55.jpg", "url56.jpg" }, IsAdopted = true, Health = "Healthy", Weight = 0.1m, BreedId = 28, PetTypeId = 6, ShelterId = 1024 },
		   new Pet { Id = 29, PetName = "Newt", CreatedTime = DateTime.Now.AddMonths(-random.Next(1, 12)), Description = "Amphibious Newt", Size = "Small", Age = 2, Gender = Gender.Female, ImageUrls = new string[] { "url57.jpg", "url58.jpg" }, IsAdopted = false, Health = "Healthy", Weight = 0.07m, BreedId = 29, PetTypeId = 6, ShelterId = 1024 },
		   new Pet { Id = 30, PetName = "Scales", CreatedTime = DateTime.Now.AddMonths(-random.Next(1, 12)), Description = "Scaly Iguana", Size = "Medium", Age = 5, Gender = Gender.Male, ImageUrls = new string[] { "url59.jpg", "url60.jpg" }, IsAdopted = true, Health = "Healthy", Weight = 1.5m, BreedId = 30, PetTypeId = 6, ShelterId = 1024 },

		   // Dogs Continued
		   new Pet { Id = 31, PetName = "Rex", CreatedTime = DateTime.Now.AddMonths(-random.Next(1, 12)), Description = "Guard Dog Rottweiler", Size = "Large", Age = 4, Gender = Gender.Male, ImageUrls = new string[] { "url61.jpg", "url62.jpg" }, IsAdopted = false, Health = "Healthy", Weight = 50.0m, BreedId = 31, PetTypeId = 1, ShelterId = 1024 },
		   new Pet { Id = 32, PetName = "Milo", CreatedTime = DateTime.Now.AddMonths(-random.Next(1, 12)), Description = "Playful Pug", Size = "Small", Age = 2, Gender = Gender.Male, ImageUrls = new string[] { "url63.jpg", "url64.jpg" }, IsAdopted = true, Health = "Healthy", Weight = 8.5m, BreedId = 32, PetTypeId = 1, ShelterId = 1024 },
		   new Pet { Id = 33, PetName = "Bailey", CreatedTime = DateTime.Now.AddMonths(-random.Next(1, 12)), Description = "Adorable Shih Tzu", Size = "Small", Age = 3, Gender = Gender.Female, ImageUrls = new string[] { "url65.jpg", "url66.jpg" }, IsAdopted = false, Health = "Healthy", Weight = 6.2m, BreedId = 33, PetTypeId = 1, ShelterId = 1023 },
		   new Pet { Id = 34, PetName = "Sasha", CreatedTime = DateTime.Now.AddMonths(-random.Next(1, 12)), Description = "Agile Greyhound", Size = "Large", Age = 4, Gender = Gender.Female, ImageUrls = new string[] { "url67.jpg", "url68.jpg" }, IsAdopted = true, Health = "Healthy", Weight = 28.0m, BreedId = 34, PetTypeId = 1, ShelterId = 1023 },
		   new Pet { Id = 35, PetName = "Rocky", CreatedTime = DateTime.Now.AddMonths(-random.Next(1, 12)), Description = "Energetic Boxer", Size = "Large", Age = 3, Gender = Gender.Male, ImageUrls = new string[] { "url69.jpg", "url70.jpg" }, IsAdopted = false, Health = "Healthy", Weight = 35.0m, BreedId = 35, PetTypeId = 1, ShelterId = 1023 },

		   // Cats Continued
		   new Pet { Id = 36, PetName = "Toby", CreatedTime = DateTime.Now.AddMonths(-random.Next(1, 12)), Description = "Affectionate Ragdoll", Size = "Large", Age = 2, Gender = Gender.Male, ImageUrls = new string[] { "url71.jpg", "url72.jpg" }, IsAdopted = true, Health = "Healthy", Weight = 9.0m, BreedId = 36, PetTypeId = 2, ShelterId = 1023 },
		   new Pet { Id = 37, PetName = "Misty", CreatedTime = DateTime.Now.AddMonths(-random.Next(1, 12)), Description = "Quiet British Shorthair", Size = "Medium", Age = 3, Gender = Gender.Female, ImageUrls = new string[] { "url73.jpg", "url74.jpg" }, IsAdopted = false, Health = "Healthy", Weight = 7.0m, BreedId = 37, PetTypeId = 2, ShelterId = 1022 },
		   new Pet { Id = 38, PetName = "Oscar", CreatedTime = DateTime.Now.AddMonths(-random.Next(1, 12)), Description = "Mischievous Sphynx", Size = "Medium", Age = 4, Gender = Gender.Male, ImageUrls = new string[] { "url75.jpg", "url76.jpg" }, IsAdopted = true, Health = "Healthy", Weight = 8.0m, BreedId = 38, PetTypeId = 2, ShelterId = 1022 },
		   new Pet { Id = 39, PetName = "Ginger", CreatedTime = DateTime.Now.AddMonths(-random.Next(1, 12)), Description = "Active Abyssinian", Size = "Small", Age = 2, Gender = Gender.Female, ImageUrls = new string[] { "url77.jpg", "url78.jpg" }, IsAdopted = false, Health = "Healthy", Weight = 5.5m, BreedId = 39, PetTypeId = 2, ShelterId = 1022 },
		   new Pet { Id = 40, PetName = "Jasper", CreatedTime = DateTime.Now.AddMonths(-random.Next(1, 12)), Description = "Laid-back Birman", Size = "Medium", Age = 3, Gender = Gender.Male, ImageUrls = new string[] { "url79.jpg", "url80.jpg" }, IsAdopted = true, Health = "Healthy", Weight = 6.5m, BreedId = 40, PetTypeId = 2, ShelterId = 1022 },

		   // Birds Continued
		   new Pet { Id = 41, PetName = "Sunshine", CreatedTime = DateTime.Now.AddMonths(-random.Next(1, 12)), Description = "Bright Sun Conure", Size = "Small", Age = 3, Gender = Gender.Female, ImageUrls = new string[] { "url81.jpg", "url82.jpg" }, IsAdopted = false, Health = "Healthy", Weight = 0.12m, BreedId = 41, PetTypeId = 3, ShelterId = 1022 },
		   new Pet { Id = 42, PetName = "Tweety", CreatedTime = DateTime.Now.AddMonths(-random.Next(1, 12)), Description = "Chirpy Canary", Size = "Small", Age = 1, Gender = Gender.Male, ImageUrls = new string[] { "url83.jpg", "url84.jpg" }, IsAdopted = false, Health = "Healthy", Weight = 0.03m, BreedId = 42, PetTypeId = 3, ShelterId = 1022 },
		   new Pet { Id = 43, PetName = "Buddy", CreatedTime = DateTime.Now.AddMonths(-random.Next(1, 12)), Description = "Friendly Budgie", Size = "Small", Age = 2, Gender = Gender.Male, ImageUrls = new string[] { "url85.jpg", "url86.jpg" }, IsAdopted = true, Health = "Healthy", Weight = 0.04m, BreedId = 43, PetTypeId = 3, ShelterId = 1022 },
		   new Pet { Id = 44, PetName = "Chirpy", CreatedTime = DateTime.Now.AddMonths(-random.Next(1, 12)), Description = "Talkative Parakeet", Size = "Small", Age = 2, Gender = Gender.Female, ImageUrls = new string[] { "url87.jpg", "url88.jpg" }, IsAdopted = false, Health = "Healthy", Weight = 0.05m, BreedId = 44, PetTypeId = 3, ShelterId = 1021 },
		   new Pet { Id = 45, PetName = "Pepper", CreatedTime = DateTime.Now.AddMonths(-random.Next(1, 12)), Description = "Noisy Cockatoo", Size = "Medium", Age = 4, Gender = Gender.Male, ImageUrls = new string[] { "url89.jpg", "url90.jpg" }, IsAdopted = true, Health = "Healthy", Weight = 0.5m, BreedId = 45, PetTypeId = 3, ShelterId = 1021 },

		   // Reptiles Continued
		   new Pet { Id = 46, PetName = "Slither", CreatedTime = DateTime.Now.AddMonths(-random.Next(1, 12)), Description = "Venomous King Cobra", Size = "Large", Age = 5, Gender = Gender.Male, ImageUrls = new string[] { "url91.jpg", "url92.jpg" }, IsAdopted = false, Health = "Healthy", Weight = 6.0m, BreedId = 46, PetTypeId = 4, ShelterId = 1021 },
		   new Pet { Id = 47, PetName = "Rex", CreatedTime = DateTime.Now.AddMonths(-random.Next(1, 12)), Description = "Large Komodo Dragon", Size = "Large", Age = 7, Gender = Gender.Male, ImageUrls = new string[] { "url93.jpg", "url94.jpg" }, IsAdopted = false, Health = "Healthy", Weight = 70.0m, BreedId = 47, PetTypeId = 4, ShelterId = 1021 },
		   new Pet { Id = 48, PetName = "Ivy", CreatedTime = DateTime.Now.AddMonths(-random.Next(1, 12)), Description = "Green Iguana", Size = "Medium", Age = 4, Gender = Gender.Female, ImageUrls = new string[] { "url95.jpg", "url96.jpg" }, IsAdopted = true, Health = "Healthy", Weight = 3.5m, BreedId = 48, PetTypeId = 4, ShelterId = 1021 },
		   new Pet { Id = 49, PetName = "Spike", CreatedTime = DateTime.Now.AddMonths(-random.Next(1, 12)), Description = "Horned Lizard", Size = "Medium", Age = 5, Gender = Gender.Male, ImageUrls = new string[] { "url97.jpg", "url98.jpg" }, IsAdopted = false, Health = "Healthy", Weight = 2.5m, BreedId = 49, PetTypeId = 4, ShelterId = 1021 },
		   new Pet { Id = 50, PetName = "Shelly", CreatedTime = DateTime.Now.AddMonths(-random.Next(1, 12)), Description = "Giant Tortoise", Size = "Large", Age = 100, Gender = Gender.Male, ImageUrls = new string[] { "url99.jpg", "url100.jpg" }, IsAdopted = true, Health = "Healthy", Weight = 200.0m, BreedId = 50, PetTypeId = 4, ShelterId = 1021 });

		}

	}
}
