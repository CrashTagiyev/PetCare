using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.HelperMethods
{
	public static class HelperMethods
	{
		private static bool IsImageFile(IFormFile file)
		{
			if (file == null) return false;

			var allowedExtensions = new[] { ".jpg", ".jpeg", ".png", ".gif", ".bmp" };
			var fileExtension = Path.GetExtension(file.FileName).ToLower();

			return allowedExtensions.Contains(fileExtension);
		}
	}
}
