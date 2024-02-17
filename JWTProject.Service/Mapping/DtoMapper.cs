using AutoMapper;
using JWTProject.Core.Models.DTOs;
using JWTProject.Core.Models.DTOs.AuthDtos;
using JWTProject.Core.Models.Entities;

namespace JWTProject.Service.Mapping
{
    public class DtoMapper : Profile
    {
        public DtoMapper()
        {
            CreateMap<ProductDto, Product>().ReverseMap();
            CreateMap<UserAppDto, UserApp>().ReverseMap();
        }
    }
}
