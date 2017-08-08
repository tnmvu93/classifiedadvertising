using AutoMapper;
using ClassifiedAdvertising.Data.Entities;
using ClassifiedAdvertising.Data.Repositories;
using ClassifiedAdvertising.Service.Dtos;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClassifiedAdvertising.Service.Services.Implementations
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IAuthenticationRepository _authenticationRepository;
        private readonly IMapper _mapper;

        public AuthenticationService(IAuthenticationRepository authenticationRepository, IMapper mapper)
        {
            _authenticationRepository = authenticationRepository;
            _mapper = mapper;
        }

        public async Task<UserDto> FindUserAsync(string username, string password)
        {
            var user = await _authenticationRepository.FindUserAsync(username, password);
            var result = _mapper.Map<UserDto>(user);
            return result;
        }

        public async Task<List<string>> RegisterUserAsync(CreateUserDto dto)
        {
            var user = _mapper.Map<User>(dto);
            var result = await _authenticationRepository.RegisterUserAsync(user, dto.Password);

            var errors = new List<string>();

            if (!result.Succeeded)
            {
                errors = result.Errors.Select(x => x.Description).ToList();
            }

            return errors;
        }
    }
}
