using Domain.Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistance.Configurations
{
	internal class BreedConfig : IEntityTypeConfiguration<Breed>
	{
		public void Configure(EntityTypeBuilder<Breed> builder)
		{
			//Relations
			builder.HasOne(b => b.PetType)
				.WithMany(pt => pt.Breeds)
				.HasForeignKey(b => b.PetTypeId)
				.OnDelete(DeleteBehavior.Restrict);

			//Properties
			builder.Property(b => b.PetTypeId).IsRequired();
			builder.Property(b => b.BreedName).IsRequired();


			//Data seed
			builder.HasData(
				// Dog Breeds
				new Breed { Id = 1, PetTypeId = 1, BreedName = "Labrador Retriever" },
				new Breed { Id = 2, PetTypeId = 1, BreedName = "German Shepherd" },
				new Breed { Id = 3, PetTypeId = 1, BreedName = "Golden Retriever" },
				new Breed { Id = 4, PetTypeId = 1, BreedName = "French Bulldog" },
				new Breed { Id = 5, PetTypeId = 1, BreedName = "Bulldog" },
				new Breed { Id = 6, PetTypeId = 1, BreedName = "Beagle" },
				new Breed { Id = 7, PetTypeId = 1, BreedName = "Poodle" },
				new Breed { Id = 8, PetTypeId = 1, BreedName = "Rottweiler" },
				new Breed { Id = 9, PetTypeId = 1, BreedName = "Yorkshire Terrier" },
				new Breed { Id = 10, PetTypeId = 1, BreedName = "Boxer" },
				new Breed { Id = 11, PetTypeId = 1, BreedName = "Dachshund" },
				new Breed { Id = 12, PetTypeId = 1, BreedName = "Pembroke Welsh Corgi" },
				new Breed { Id = 13, PetTypeId = 1, BreedName = "Doberman Pinscher" },
				new Breed { Id = 14, PetTypeId = 1, BreedName = "Shih Tzu" },
				new Breed { Id = 15, PetTypeId = 1, BreedName = "Siberian Husky" },
				new Breed { Id = 16, PetTypeId = 1, BreedName = "Great Dane" },
				new Breed { Id = 17, PetTypeId = 1, BreedName = "Border Collie" },
				new Breed { Id = 18, PetTypeId = 1, BreedName = "Chihuahua" },
				new Breed { Id = 19, PetTypeId = 1, BreedName = "Boston Terrier" },
				new Breed { Id = 20, PetTypeId = 1, BreedName = "Australian Shepherd" },
				new Breed { Id = 21, PetTypeId = 1, BreedName = "Pug" },
				new Breed { Id = 22, PetTypeId = 1, BreedName = "Havanese" },
				new Breed { Id = 23, PetTypeId = 1, BreedName = "Maltese" },
				new Breed { Id = 24, PetTypeId = 1, BreedName = "Saint Bernard" },
				new Breed { Id = 25, PetTypeId = 1, BreedName = "Akita" },
				new Breed { Id = 26, PetTypeId = 1, BreedName = "Alaskan Malamute" },
				new Breed { Id = 27, PetTypeId = 1, BreedName = "Bichon Frise" },
				new Breed { Id = 28, PetTypeId = 1, BreedName = "Bull Terrier" },
				new Breed { Id = 29, PetTypeId = 1, BreedName = "Cane Corso" },
				new Breed { Id = 30, PetTypeId = 1, BreedName = "Chow Chow" },
				new Breed { Id = 31, PetTypeId = 1, BreedName = "Cocker Spaniel" },
				new Breed { Id = 32, PetTypeId = 1, BreedName = "Dogo Argentino" },
				new Breed { Id = 33, PetTypeId = 1, BreedName = "English Springer Spaniel" },
				new Breed { Id = 34, PetTypeId = 1, BreedName = "Irish Setter" },
				new Breed { Id = 35, PetTypeId = 1, BreedName = "Jack Russell Terrier" },
				new Breed { Id = 36, PetTypeId = 1, BreedName = "Lhasa Apso" },
				new Breed { Id = 37, PetTypeId = 1, BreedName = "Miniature Schnauzer" },
				new Breed { Id = 38, PetTypeId = 1, BreedName = "Neapolitan Mastiff" },
				new Breed { Id = 39, PetTypeId = 1, BreedName = "Old English Sheepdog" },
				new Breed { Id = 40, PetTypeId = 1, BreedName = "Papillon" },
				new Breed { Id = 41, PetTypeId = 1, BreedName = "Pekingese" },
				new Breed { Id = 42, PetTypeId = 1, BreedName = "Petit Basset Griffon Vendeen" },
				new Breed { Id = 43, PetTypeId = 1, BreedName = "Pomeranian" },
				new Breed { Id = 44, PetTypeId = 1, BreedName = "Portuguese Water Dog" },
				new Breed { Id = 45, PetTypeId = 1, BreedName = "Samoyed" },
				new Breed { Id = 46, PetTypeId = 1, BreedName = "Scottish Terrier" },
				new Breed { Id = 47, PetTypeId = 1, BreedName = "Shiba Inu" },
				new Breed { Id = 48, PetTypeId = 1, BreedName = "Weimaraner" },
				new Breed { Id = 49, PetTypeId = 1, BreedName = "Whippet" },

				// Cat Breeds
				new Breed { Id = 50, PetTypeId = 2, BreedName = "Persian" },
				new Breed { Id = 51, PetTypeId = 2, BreedName = "Maine Coon" },
				new Breed { Id = 52, PetTypeId = 2, BreedName = "Siamese" },
				new Breed { Id = 53, PetTypeId = 2, BreedName = "Ragdoll" },
				new Breed { Id = 54, PetTypeId = 2, BreedName = "British Shorthair" },
				new Breed { Id = 55, PetTypeId = 2, BreedName = "Sphynx" },
				new Breed { Id = 56, PetTypeId = 2, BreedName = "Bengal" },
				new Breed { Id = 57, PetTypeId = 2, BreedName = "Scottish Fold" },
				new Breed { Id = 58, PetTypeId = 2, BreedName = "Abyssinian" },
				new Breed { Id = 59, PetTypeId = 2, BreedName = "Burmese" },
				new Breed { Id = 60, PetTypeId = 2, BreedName = "Somali" },
				new Breed { Id = 61, PetTypeId = 2, BreedName = "Manx" },
				new Breed { Id = 62, PetTypeId = 2, BreedName = "Norwegian Forest Cat" },
				new Breed { Id = 63, PetTypeId = 2, BreedName = "Devon Rex" },
				new Breed { Id = 64, PetTypeId = 2, BreedName = "Cornish Rex" },
				new Breed { Id = 65, PetTypeId = 2, BreedName = "Russian Blue" },
				new Breed { Id = 66, PetTypeId = 2, BreedName = "Birman" },
				new Breed { Id = 67, PetTypeId = 2, BreedName = "Ocicat" },
				new Breed { Id = 68, PetTypeId = 2, BreedName = "American Shorthair" },
				new Breed { Id = 69, PetTypeId = 2, BreedName = "Turkish Angora" },
				new Breed { Id = 70, PetTypeId = 2, BreedName = "Selkirk Rex" },
				new Breed { Id = 71, PetTypeId = 2, BreedName = "Exotic Shorthair" },
				new Breed { Id = 72, PetTypeId = 2, BreedName = "LaPerm" },
				new Breed { Id = 73, PetTypeId = 2, BreedName = "Havana Brown" },
				new Breed { Id = 74, PetTypeId = 2, BreedName = "Tonkinese" },
				new Breed { Id = 75, PetTypeId = 2, BreedName = "Egyptian Mau" },
				new Breed { Id = 76, PetTypeId = 2, BreedName = "Singapura" },
				new Breed { Id = 77, PetTypeId = 2, BreedName = "Japanese Bobtail" },
				new Breed { Id = 78, PetTypeId = 2, BreedName = "American Curl" },

				// Bird Breeds
				new Breed { Id = 79, PetTypeId = 3, BreedName = "Parrot" },
				new Breed { Id = 80, PetTypeId = 3, BreedName = "Canary" },
				new Breed { Id = 81, PetTypeId = 3, BreedName = "Budgerigar" },
				new Breed { Id = 82, PetTypeId = 3, BreedName = "Cockatiel" },
				new Breed { Id = 83, PetTypeId = 3, BreedName = "Lovebird" },
				new Breed { Id = 84, PetTypeId = 3, BreedName = "Macaw" },
				new Breed { Id = 85, PetTypeId = 3, BreedName = "Conure" },
				new Breed { Id = 86, PetTypeId = 3, BreedName = "African Grey Parrot" },
				new Breed { Id = 87, PetTypeId = 3, BreedName = "Finches" },
				new Breed { Id = 88, PetTypeId = 3, BreedName = "Quaker Parrot" },
				new Breed { Id = 89, PetTypeId = 3, BreedName = "Amazon Parrot" },
				new Breed { Id = 90, PetTypeId = 3, BreedName = "Eclectus Parrot" },
				new Breed { Id = 91, PetTypeId = 3, BreedName = "Pigeon" },
				new Breed { Id = 92, PetTypeId = 3, BreedName = "Dove" },
				new Breed { Id = 93, PetTypeId = 3, BreedName = "Cockatoo" },
				new Breed { Id = 94, PetTypeId = 3, BreedName = "Sun Conure" },
				new Breed { Id = 95, PetTypeId = 3, BreedName = "Hyacinth Macaw" },
				new Breed { Id = 96, PetTypeId = 3, BreedName = "Lorikeet" },
				new Breed { Id = 97, PetTypeId = 3, BreedName = "Zebra Finch" },
				new Breed { Id = 98, PetTypeId = 3, BreedName = "Gouldian Finch" },
				new Breed { Id = 99, PetTypeId = 3, BreedName = "Canary Winged Parakeet" },
				new Breed { Id = 100, PetTypeId = 3, BreedName = "Quail" },

				// Reptile Breeds
				new Breed { Id = 101, PetTypeId = 4, BreedName = "Iguana" },
				new Breed { Id = 102, PetTypeId = 4, BreedName = "Gecko" },
				new Breed { Id = 103, PetTypeId = 4, BreedName = "Bearded Dragon" },
				new Breed { Id = 104, PetTypeId = 4, BreedName = "Chameleon" },
				new Breed { Id = 105, PetTypeId = 4, BreedName = "Python" },
				new Breed { Id = 106, PetTypeId = 4, BreedName = "Boa Constrictor" },
				new Breed { Id = 107, PetTypeId = 4, BreedName = "Skink" },
				new Breed { Id = 108, PetTypeId = 4, BreedName = "Tortoise" },
				new Breed { Id = 109, PetTypeId = 4, BreedName = "Turtle" },
				new Breed { Id = 110, PetTypeId = 4, BreedName = "Monitor Lizard" },
				new Breed { Id = 111, PetTypeId = 4, BreedName = "Water Dragon" },
				new Breed { Id = 112, PetTypeId = 4, BreedName = "Uromastyx" },
				new Breed { Id = 113, PetTypeId = 4, BreedName = "Horned Toad" },

				// Rodent Breeds
				new Breed { Id = 114, PetTypeId = 5, BreedName = "Hamster" },
				new Breed { Id = 115, PetTypeId = 5, BreedName = "Guinea Pig" },
				new Breed { Id = 116, PetTypeId = 5, BreedName = "Rat" },
				new Breed { Id = 117, PetTypeId = 5, BreedName = "Mouse" },
				new Breed { Id = 118, PetTypeId = 5, BreedName = "Gerbil" },
				new Breed { Id = 119, PetTypeId = 5, BreedName = "Chinchilla" },
				new Breed { Id = 120, PetTypeId = 5, BreedName = "Degu" },
				new Breed { Id = 121, PetTypeId = 5, BreedName = "Capybara" },
				new Breed { Id = 122, PetTypeId = 5, BreedName = "Prairie Dog" },

				// Fish Breeds
				new Breed { Id = 123, PetTypeId = 6, BreedName = "Goldfish" },
				new Breed { Id = 124, PetTypeId = 6, BreedName = "Betta" },
				new Breed { Id = 125, PetTypeId = 6, BreedName = "Guppy" },
				new Breed { Id = 126, PetTypeId = 6, BreedName = "Neon Tetra" },
				new Breed { Id = 127, PetTypeId = 6, BreedName = "Angelfish" },
				new Breed { Id = 128, PetTypeId = 6, BreedName = "Oscar" },
				new Breed { Id = 129, PetTypeId = 6, BreedName = "Clownfish" },
				new Breed { Id = 130, PetTypeId = 6, BreedName = "Corydoras Catfish" },
				new Breed { Id = 131, PetTypeId = 6, BreedName = "Molly" },
				new Breed { Id = 132, PetTypeId = 6, BreedName = "Swordtail" },
				new Breed { Id = 133, PetTypeId = 6, BreedName = "Rainbowfish" },
				new Breed { Id = 134, PetTypeId = 6, BreedName = "Plecostomus" },
				new Breed { Id = 135, PetTypeId = 6, BreedName = "Gourami" },
				new Breed { Id = 136, PetTypeId = 6, BreedName = "Danios" },
				new Breed { Id = 137, PetTypeId = 6, BreedName = "Apistogramma" },
				new Breed { Id = 138, PetTypeId = 6, BreedName = "Discus" },
				new Breed { Id = 139, PetTypeId = 6, BreedName = "Koi" },

				// Farm Animal Breeds
				new Breed { Id = 140, PetTypeId = 7, BreedName = "Holstein Cow" },
				new Breed { Id = 141, PetTypeId = 7, BreedName = "Angus Cow" },
				new Breed { Id = 142, PetTypeId = 7, BreedName = "Jersey Cow" },
				new Breed { Id = 143, PetTypeId = 7, BreedName = "Guernsey Cow" },
				new Breed { Id = 144, PetTypeId = 7, BreedName = "Merino Sheep" },
				new Breed { Id = 145, PetTypeId = 7, BreedName = "Suffolk Sheep" },
				new Breed { Id = 146, PetTypeId = 7, BreedName = "Dorset Sheep" },
				new Breed { Id = 147, PetTypeId = 7, BreedName = "Hampshire Sheep" },
				new Breed { Id = 148, PetTypeId = 7, BreedName = "Berkshire Pig" },
				new Breed { Id = 149, PetTypeId = 7, BreedName = "Duroc Pig" },
				new Breed { Id = 150, PetTypeId = 7, BreedName = "Yorkshire Pig" },
				new Breed { Id = 151, PetTypeId = 7, BreedName = "Landrace Pig" },
				new Breed { Id = 152, PetTypeId = 7, BreedName = "Rhode Island Red Chicken" },
				new Breed { Id = 153, PetTypeId = 7, BreedName = "Leghorn Chicken" },
				new Breed { Id = 154, PetTypeId = 7, BreedName = "Plymouth Rock Chicken" },
				new Breed { Id = 155, PetTypeId = 7, BreedName = "Sussex Chicken" },
				new Breed { Id = 156, PetTypeId = 7, BreedName = "Turkeys" },
				new Breed { Id = 157, PetTypeId = 7, BreedName = "Ducks" },
				new Breed { Id = 158, PetTypeId = 7, BreedName = "Goats" },
				new Breed { Id = 159, PetTypeId = 7, BreedName = "Llamas" },
				new Breed { Id = 160, PetTypeId = 7, BreedName = "Alpacas" }
			);
		}
	}
}
