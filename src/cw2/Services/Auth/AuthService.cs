using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cw2.Services.Auth;
using cw2.Services.DTO;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace cw2.Auth
{
    public class AuthService : IAuthService
    {
        private IPasswordHasher<User> _passwordHasher;
        private UsersRepository _usersRepository;
        private readonly IJwtHandler _jwtHandler;

        public Task SignUpAsync(Guid id, string email, string password, string role)
        {
            var user = new User(id, email, role);
            user.SetPassword(password, _passwordHasher);
            _usersRepository.Add(user);

            return Task.FromResult(user);
        }

        public Task<JsonWebToken> SignInAsync(string email, string password)
        {
            var user = _usersRepository.GetByEmail(email);
            var jwt = _jwtHandler.CreateToken(user.Id.ToString(), user.Role, new Dictionary<string, string>());

            return Task.FromResult(jwt);

        }

        public AuthService(IPasswordHasher<User> passwordHasher, UsersRepository usersRepository, IJwtHandler jwtHandler)
        {
            _jwtHandler = jwtHandler;
            _passwordHasher = passwordHasher;
            _usersRepository = usersRepository;
        }

       
    }
}
