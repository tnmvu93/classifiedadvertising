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

        public async Task CreateUser(CreateUserDto userDto)
        {
            var user = _mapper.Map<User>(userDto);
            
            _userRepository.Create(user);
            await _userRepository.SaveChanges();
        }

        public User GetUserById(int id)
        {
            var result = _userRepository.GetById(id);
            return result.Result;
        }
    }
}
