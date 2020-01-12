using System.Linq;
using AutoMapper;
using dotnet.api.Dtos;
using dotnet.api.Models;

namespace dotnet.api.helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<User, UserForListDto>()
                .ForMember(dest => dest.PhotoUrl, opt => opt.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain).Url))
                .ForMember(dest => dest.Age, opt => opt.MapFrom(src => src.DateOfBirth.CalculateAge()));
            CreateMap<User, UserForDetailedDto>()
                .ForMember(dest => dest.PhotoUrl, opt => opt.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain).Url))
                .ForMember(dest => dest.Age, opt => opt.MapFrom(src => src.DateOfBirth.CalculateAge()));
            CreateMap<Photo, PhotoForDetailedDto>();
            CreateMap<UserForUpdateDto, User>();
        }
    }
}