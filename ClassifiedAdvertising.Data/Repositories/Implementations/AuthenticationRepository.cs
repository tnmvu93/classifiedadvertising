using ClassifiedAdvertising.Data.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Threading.Tasks;

namespace ClassifiedAdvertising.Data.Repositories.Implementations
{
    public class AuthenticationRepository : IAuthenticationRepository
    {
        private readonly UserManager<User> _userManager;

        public AuthenticationRepository(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public async Task<User> FindUserAsync(string username, string password)
        {
            var user = await _userManager.FindByNameAsync(username);
            if (user != null && await _userManager.CheckPasswordAsync(user, password))
            {
                return user;
            }
            return null;
        }

        public async Task<IdentityResult> RegisterUserAsync(User user, string password)
        {
            var result = await _userManager.CreateAsync(user, password);
            return result;
        }
    }
}
