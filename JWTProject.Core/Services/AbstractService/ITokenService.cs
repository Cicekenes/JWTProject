using JWTProject.Core.Configuration;
using JWTProject.Core.Models.DTOs;
using JWTProject.Core.Models.Entities;

namespace JWTProject.Core.Services.AbstractService
{
    public interface ITokenService
    {
        TokenDto CreateToken(UserApp userApp);
        ClientTokenDto CreateTokenByClient(Client client);
    }
}
