using Microsoft.AspNetCore.Http;
using System.Net;

namespace Application.ServiceAbstracts
{
	public interface IBlobService
	{
		Task<string> UploadImageFileAsync(IFormFile file);
		Task<ICollection<string>> UploadImageFileRangeAsync(IFormFileCollection fileCollection);
		Task<HttpStatusCode> DeleteImageFileAsync(string imageUrl);
	}
}
