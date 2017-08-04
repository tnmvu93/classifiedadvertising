using ClassifiedAdvertising.Data.Entities;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace ClassifiedAdvertising.Data.Repositories
{
    public interface IAuthenticationRepository
    {
        Task<IdentityResult> RegisterUserAsync(User user, string password);
        Task<User> FindUserAsync(string username, string password);
    }
}
