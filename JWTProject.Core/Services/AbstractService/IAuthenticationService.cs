using JWTProject.Core.Models.DTOs;
using JWTProject.Core.Models.DTOs.AuthDtos;
using SharedLibrary.Dtos;

namespace JWTProject.Core.Services.AbstractService
{
    public interface IAuthenticationService
    {
        Task<Response<TokenDto>> CreateTokenAsync(LoginDto loginDto);
        Task<Response<TokenDto>> CreateTokenByRefreshToken(string refreshToken);
        Task<Response<NoDataDto>> RevokeRefreshToken(string refreshToken);
        Response<ClientTokenDto> CreateTokenByClient(ClientLoginDto clientLoginDto);
    }
}
