using Domain.DTOs.TokenDTOs;
using Domain.Models.AuthModels.Tokens;

namespace Application.ServiceAbstracts
{
	public interface ITokenService
	{
		Task<string> GenerateAccessToken(TokenRequestDTO dto);
		Task<RefreshToken> GenerateRefreshToken();
	}
}
