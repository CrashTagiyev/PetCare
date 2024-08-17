using Microsoft.AspNetCore.Http;

namespace Domain.HelperMethods
{
	public static class HelperMethods
	{
		public static bool IsImageFile(IFormFile? file)
		{
			if (file == null) return false;

			var allowedExtensions = new[] { ".jpg", ".jpeg", ".png", ".gif", ".bmp" };
			var fileExtension = Path.GetExtension(file.FileName).ToLower();

			return allowedExtensions.Contains(fileExtension);
		}
	}
}
