using Domain.DTOs.TokenDTOs;
using Domain.Models.AuthModels.Tokens;

namespace Application.AbstractServices
{
	public interface ITokenService
	{
		string GenerateAccessToken(TokenRequestDTO dto);
		RefreshToken GenerateRefreshToken();
	}
}
