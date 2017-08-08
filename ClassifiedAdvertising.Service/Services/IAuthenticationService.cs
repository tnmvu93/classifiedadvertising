using ClassifiedAdvertising.Service.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClassifiedAdvertising.Service.Services
{
    public interface IAuthenticationService
    {
        Task<UserDto> FindUserAsync(string username, string password);
        Task<List<string>> RegisterUserAsync(CreateUserDto user);
    }
}
