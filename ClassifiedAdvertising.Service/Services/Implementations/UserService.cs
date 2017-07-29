using ClassifiedAdvertising.Data.Entities;
using ClassifiedAdvertising.Data.Repositories;
using ClassifiedAdvertising.Service.Dtos;
using System.Threading.Tasks;

namespace ClassifiedAdvertising.Service.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task CreateUser(CreateUserDto userDto)
        {
            var user = new User
            {
                Email = userDto.Email,
                Name = userDto.Name
            };
            
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
