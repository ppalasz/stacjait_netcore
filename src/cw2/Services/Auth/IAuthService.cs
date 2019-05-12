using System;
using System.Threading.Tasks;
using cw2.Services.DTO;

namespace cw2.Auth
{
    public interface IAuthService
    {
        Task SignUpAsync(Guid id, string email, string password, string role);

        Task<JsonWebToken> SignInAsync(string email, string password);
    }
}