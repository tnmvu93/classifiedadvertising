using ClassifiedAdvertising.Data.Entities;
using ClassifiedAdvertising.Service.Dtos;
using System.Threading.Tasks;

namespace ClassifiedAdvertising.Service.Services
{
    public interface IUserService
    {
        User GetUserById(int id);
        Task CreateUser(CreateUserDto user);
    }
}
