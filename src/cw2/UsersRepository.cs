using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace cw2
{
    public class UsersRepository
    {
        private Dictionary<string, User> _users = new Dictionary<string, User>();

        public UsersRepository()
        {
            var userId = Guid.NewGuid();
            User newUser = new User(userId, "test@test.pl", "admin");
          
            _users.Add(newUser.Email, newUser);
        }


        public User GetByEmail(string email)
        {
            _users.TryGetValue(email, out var user);
            return user;
        }

        public void Add(User user)
        {
            _users.Add(user.Email, user);
        }

        
    }
}
