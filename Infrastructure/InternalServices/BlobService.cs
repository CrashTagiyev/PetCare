using Application.ServiceAbstracts;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.InternalServices
{
	public class BlobService : IBlobService
	{
		private readonly BlobServiceClient _blobServiceClient;
		private readonly IConfiguration _configuration;
		public BlobService(BlobServiceClient blobService, IConfiguration configuration)
		{
			_blobServiceClient = blobService;
			_configuration = configuration;
		}
		public async Task<string> UploadImageFileAsync(IFormFile file)
		{
			// Get the blob container
			var blobStorageContainerName = _blobServiceClient.GetBlobContainerClient(_configuration.GetValue<string>("PetCareImageBlobContainer"));

			// Get the blob client
			var blobStorageClient = blobStorageContainerName.GetBlobClient(file.FileName + Guid.NewGuid().ToString());

			// Read file stream
			using (var streamContent = file.OpenReadStream())
			{
				// Upload file with proper content type
				var blobHttpHeaders = new BlobHttpHeaders
				{
					ContentType = file.ContentType
				};
				await blobStorageClient.UploadAsync(streamContent, new BlobUploadOptions { HttpHeaders = blobHttpHeaders });

				// Generate URL for the uploaded file
				var blobUrl = blobStorageClient.Uri.ToString();

				// Return the URL
				return blobUrl;
			}
		}
		public async Task<ICollection<string>> UploadImageFileRangeAsync(IFormFileCollection fileCollection)
		{

			List<string> fileUrls = new List<string>();
			// Get the blob container
			var blobStorageContainerName = _blobServiceClient.GetBlobContainerClient(_configuration.GetValue<string>("PetCareImageBlobContainer"));

			foreach (var file in fileCollection)
			{

				// Get the blob client
				var blobStorageClient = blobStorageContainerName.GetBlobClient(file.FileName + Guid.NewGuid().ToString());

				// Read file stream
				using (var streamContent = file.OpenReadStream())
				{
					// Upload file with proper content type
					var blobHttpHeaders = new BlobHttpHeaders
					{
						ContentType = file.ContentType
					};
					await blobStorageClient.UploadAsync(streamContent, new BlobUploadOptions { HttpHeaders = blobHttpHeaders });

					// Generate URL for the uploaded file
					var blobUrl = blobStorageClient.Uri.ToString();
					fileUrls.Add(blobUrl);
				}
			}
			// Return the URL
			return fileUrls;
		}

	}
}
