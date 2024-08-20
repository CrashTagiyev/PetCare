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
			var blobStorageContainerName = _blobServiceClient.GetBlobContainerClient(_configuration.GetValue<string>("PetCareImageBlobContainer"));

			var blobStorageClient = blobStorageContainerName.GetBlobClient(file.FileName + Guid.NewGuid().ToString());

			using (var streamContent = file.OpenReadStream())
			{
				var blobHttpHeaders = new BlobHttpHeaders
				{
					ContentType = file.ContentType
				};
				await blobStorageClient.UploadAsync(streamContent, new BlobUploadOptions { HttpHeaders = blobHttpHeaders });

				var blobUrl = blobStorageClient.Uri.ToString();

				return blobUrl;
			}
		}
		public async Task<ICollection<string>> UploadImageFileRangeAsync(IFormFileCollection fileCollection)
		{

			List<string> fileUrls = new List<string>();
			var blobStorageContainerName = _blobServiceClient.GetBlobContainerClient(_configuration.GetValue<string>("PetCareImageBlobContainer"));

			foreach (var file in fileCollection)
			{

				var blobStorageClient = blobStorageContainerName.GetBlobClient(file.FileName + Guid.NewGuid().ToString());

				using (var streamContent = file.OpenReadStream())
				{
					var blobHttpHeaders = new BlobHttpHeaders
					{
						ContentType = file.ContentType
					};
					await blobStorageClient.UploadAsync(streamContent, new BlobUploadOptions { HttpHeaders = blobHttpHeaders });

					var blobUrl = blobStorageClient.Uri.ToString();
					fileUrls.Add(blobUrl);
				}
			}
			return fileUrls;
		}

	}
}
