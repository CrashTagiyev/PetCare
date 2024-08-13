using Microsoft.AspNetCore.Http;

namespace Application.ServiceAbstracts
{
	public interface IBlobService
	{
		Task<string> UploadImageFileAsync(IFormFile file);
		Task<ICollection<string>> UploadImageFileRangeAsync(IFormFileCollection fileCollection);
	}
}
