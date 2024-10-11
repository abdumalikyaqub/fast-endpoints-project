using AutoMapper;
using FastEndApp.API.Contracts.Responses;
using FastEndApp.Core.Entities;

namespace FastEndApp.API.Mappers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles() 
        { 
            CreateMap<GetUsersResponse, User>().ReverseMap();
        }
    }
}
