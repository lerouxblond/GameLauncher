using GameLauncher.Data;
using GameLauncher.Helpers;
using GameLauncher.Models;
using GameLauncher.Models.Utils;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLauncher.Services.Auth
{
    public class AuthService
    {
        private readonly AppDbContext _db;

        public AuthService(AppDbContext db) { _db = db; }

        #region Login Methods
        public ServiceResult<Users> Login(string identifier, string password)
        {
            try
            {
                var user = getUserByEmailOrUsername(identifier);

                if (user == null)
                    return ServiceResult<Users>.Fail("No user found.");

                var passwordIsCorrect = checkInputPassword(user.Password,  password);

                if (!passwordIsCorrect)
                    return ServiceResult<Users>.Fail("Password is incorrect.");

                return ServiceResult<Users>.Successful("User connected with success.");
            }
            catch (Exception ex)
            {
                return ServiceResult<Users>.Fail($"Unidentify error detected. {ex.Message}");    
            }
        }

        private bool checkInputPassword(string dbPassword, string inputPassword)
        {
            return PasswordHashHelper.VerifyPassword(dbPassword, inputPassword);
        }

        public Users? getUserByEmailOrUsername(string identifier)
        {
            return _db.Users.FirstOrDefault(u => u.Username == identifier || u.Email == identifier);
        }
        #endregion

        #region Login Methods
        public ServiceResult<Users> Register(string username, string email, string password)
        {
            try
            {
                if (CheckIfUserAllreadyExists(username, email) != null)
                    return ServiceResult<Users>.Fail("User already exists.");

                if (!CheckUsernameValidity(username))
                    return ServiceResult<Users>.Fail("Username must not be empty and 3 lenght long");

                if (!CheckPasswordValidity(password))
                    return ServiceResult<Users>.Fail("Password is not valid. It must contain at least 8 characters, 1 uppercase, 1 lowercase, 1 digit, and 1 special character.");

                if (!CheckEmailValidity(email))
                    return ServiceResult<Users>.Fail("Email is not valid. Example format: user@email.com.");

                string hashedPassword = PasswordHashHelper.HashPassword(password);
                var user = new Users
                {
                    Username = username,
                    Email = email,
                    Password = hashedPassword,
                };

                try
                {
                    _db.Users.Add(user);
                    _db.SaveChanges();
                    return ServiceResult<Users>.Ok(user);
                }
                catch (Exception ex)
                {
                    return ServiceResult<Users>.Fail($"Database error: {ex.Message}");
                }
            }
            catch (Exception ex)
            {
                return ServiceResult<Users>.Fail($"Unexpected error: {ex.Message}");
            }
        }

        private bool CheckUsernameValidity(string username)
        {
            return string.IsNullOrWhiteSpace(username) || username.Length >= 3;
        }

        private bool CheckEmailValidity(string email)
        {
            return EmailHelper.IsValidEmail(email);
        }

        private bool CheckPasswordValidity(string password)
        {
            var hasMinimum8Chars = password.Length >= 8;
            var hasUpperCase = password.Any(char.IsUpper);
            var hasLowerCase = password.Any(char.IsLower);
            var hasDigit = password.Any(char.IsDigit);
            var hasSpecialChar = password.Any(ch => !char.IsLetterOrDigit(ch));

            if (!hasDigit || !hasUpperCase || !hasLowerCase || !hasMinimum8Chars || !hasSpecialChar)
                return false;

            return true;
        }

        private Users? CheckIfUserAllreadyExists(string username, string email)
        {
            return _db.Users.FirstOrDefault(u => u.Username == username || u.Email == email);
        }
        #endregion


    }
}
