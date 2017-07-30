using AutoMapper;
using ClassifiedAdvertising.Data.Entities;
using ClassifiedAdvertising.Service.Dtos;

namespace ClassifiedAdvertising.Service.Mappings
{
    public class DtoToEntityMappingProfile : Profile
    {
        public DtoToEntityMappingProfile()
        {
            CreateMap<CreateUserDto, User>();
        }
    }
}
