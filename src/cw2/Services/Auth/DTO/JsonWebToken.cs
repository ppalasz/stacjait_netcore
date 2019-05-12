using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw2.Services.DTO
{
    public class JsonWebToken
    {
        public string AccessToken { get; set; }

        public string RefreshToken { get; set; }

        public long Expires { get; set; }

        public string Id { get; set; }

        public string Role { get; set; }

        public Dictionary<string, string> Claims { get; set; }
    }
}
