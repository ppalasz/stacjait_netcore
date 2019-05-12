using System;
using Microsoft.AspNetCore.Identity;

namespace cw2
{
    public class User
    {
        public Guid Id { get; private set; }
        public string Email { get; private set; }
        public string Role { get; private set; }
        public string PasswordHash { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }

        public User(Guid id, string email, string role)
        {
            Id = id;
            Email = email.ToLowerInvariant();
            Role = role.ToLowerInvariant();
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }

        public void SetPassword(string password, IPasswordHasher<User> passwordHasher)
        {
            PasswordHash = passwordHasher.HashPassword(this, password);
        }
    }
}