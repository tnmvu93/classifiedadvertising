using AutoMapper;
using ClassifiedAdvertising.Data.Entities;
using ClassifiedAdvertising.Data.Repositories;
using ClassifiedAdvertising.Service.Dtos;
using System.Threading.Tasks;

namespace ClassifiedAdvertising.Service.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            var user = await _userRepository.GetByIdAsync(id);
            return user;
        }

        public async Task<UserDto> CreateUserAsync(CreateUserDto createUserDto)
        {
            var user = _mapper.Map<User>(createUserDto);
            
            _userRepository.Create(user);
            await _userRepository.SaveChangesAsync();

            var userDto = _mapper.Map<UserDto>(user);
            return userDto;
        }        
    }
}
