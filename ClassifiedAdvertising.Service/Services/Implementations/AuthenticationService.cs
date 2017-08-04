using AutoMapper;
using ClassifiedAdvertising.Data.Entities;
using ClassifiedAdvertising.Data.Repositories;
using ClassifiedAdvertising.Service.Dtos;
using System;
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

        public async Task<Dictionary<string, string>> RegisterUserAsync(CreateUserDto dto)
        {
            var user = _mapper.Map<User>(dto);
            var result = await _authenticationRepository.RegisterUserAsync(user, dto.Password);

            var errors = new Dictionary<string, string>();
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    errors.Add(error.Code, error.Description);
                }
            }

            return errors;
        }
    }
}
