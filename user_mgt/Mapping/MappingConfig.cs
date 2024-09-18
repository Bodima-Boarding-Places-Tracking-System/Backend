using AutoMapper;
using user_mgt.Models.Domains;
using user_mgt.Models.DTOs;

namespace user_mgt.Mapping
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            // User to UserDto and its inheritance mapping
            CreateMap<User, UserDto>().Include<Student, StudentDto>().ReverseMap();

            // Student-specific mappings
            CreateMap<Student, StudentDto>().IncludeBase<User, UserDto>().ReverseMap();
        }

        // Optionally, this could be used to register maps manually if required
        public static IMapper RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.AddProfile<MappingConfig>(); // Register the MappingConfig profile
            });

            return mappingConfig.CreateMapper();
        }
    }
}
