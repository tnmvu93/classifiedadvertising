using ClassifiedAdvertising.Data.Entities;
using ClassifiedAdvertising.Service.Dtos;
using System.Threading.Tasks;

namespace ClassifiedAdvertising.Service.Services
{
    public interface IUserService
    {
        Task<User> GetUserByIdAsync(int id);
        Task<UserDto> CreateUserAsync(CreateUserDto user);
    }
}
