using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLauncher.Helpers
{
    public static class PasswordHashHelper
    {
        private static readonly PasswordHasher<object> _hasher = new();

        public static string HashPassword(string password)
        {
            return _hasher.HashPassword(null!, password);
        }

        public static bool VerifyPassword(string hashedPassword, string inputPassword)
        {
            var result = _hasher.VerifyHashedPassword(null!, hashedPassword, inputPassword);
            return result == PasswordVerificationResult.Success;
        }
    }
}
