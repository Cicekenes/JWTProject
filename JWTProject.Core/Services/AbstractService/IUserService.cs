using JWTProject.Core.Models.DTOs.AuthDtos;
using Microsoft.AspNetCore.Http.HttpResults;
using SharedLibrary.Dtos;

namespace JWTProject.Core.Services.AbstractService
{
    public interface IUserService
    {
        Task<Response<UserAppDto>> CreateUserAsync(CreateUserDto createUserDto);
        Task<Response<UserAppDto>> GetUserByNameAsync(string userName);
        Task<Response<NoContent>> CreateUserRoles(string userName);
    }
}
