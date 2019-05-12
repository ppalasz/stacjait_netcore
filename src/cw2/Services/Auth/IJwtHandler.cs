using System.Collections.Generic;
using cw2.Services.DTO;

namespace cw2.Services.Auth
{
    public interface IJwtHandler
    {
        JsonWebToken CreateToken(string userId, string role = null, IDictionary<string, string> claims = null);
    }
}