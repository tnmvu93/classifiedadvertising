using AutoMapper;
using ClassifiedAdvertising.Data.Entities;
using ClassifiedAdvertising.Service.Dtos;

namespace ClassifiedAdvertising.Service.Mappings
{
    public class EntityToDtoMappingProfile : Profile
    {
        public EntityToDtoMappingProfile()
        {
            CreateMap<User, UserDto>();
        }
    }
}
