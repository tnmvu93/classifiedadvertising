using AutoMapper;

namespace ClassifiedAdvertising.Service.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<EntityToDtoMappingProfile>();
                x.AddProfile<DtoToEntityMappingProfile>();
            });
        }
    }
}
