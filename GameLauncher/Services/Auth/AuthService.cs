using GameLauncher.Data;
using GameLauncher.Helpers;
using GameLauncher.Models;
using GameLauncher.Models.Utils;
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
        public ServiceResult<User> Login(string identifier, string password)
        {
            try
            {
                var user = getUserByEmailOrUsername(identifier);

                if (user == null)
                    return ServiceResult<User>.Fail("No user found.");

                var passwordIsCorrect = checkInputPassword(user.Password,  password);

                if (!passwordIsCorrect)
                    return ServiceResult<User>.Fail("Password is incorrect.");

                return ServiceResult<User>.Successful("User connected with success.");
            }
            catch (Exception ex)
            {

                return ServiceResult<User>.Fail($"Unidentify error detected. {ex.Message}");
            }
        }

        private bool checkInputPassword(string dbPassword, string inputPassword)
        {
            return PasswordHashHelper.VerifyPassword(dbPassword, inputPassword);
        }

        public User? getUserByEmailOrUsername(string identifier)
        {
            return _db.Users.FirstOrDefault(u => u.Username == identifier || u.Email == identifier);
        }
        #endregion

        #region Login Methods
        public ServiceResult<User> Register(string username, string email, string password)
        {
            try
            {
                if (CheckIfUserAllreadyExists(username, email) != null)
                    return ServiceResult<User>.Fail("User already exists.");

                if (!CheckPasswordValidity(password))
                    return ServiceResult<User>.Fail("Password is not valid. It must contain at least 8 characters, 1 uppercase, 1 lowercase, 1 digit, and 1 special character.");

                if (!CheckEmailValidity(email))
                    return ServiceResult<User>.Fail("Email is not valid. Example format: user@email.com.");

                string hashedPassword = PasswordHashHelper.HashPassword(password);
                var user = new User
                {
                    Username = username,
                    Email = email,
                    Password = hashedPassword,
                };

                try
                {
                    _db.Users.Add(user);
                    _db.SaveChanges();
                    return ServiceResult<User>.Ok(user);
                }
                catch (Exception ex)
                {
                    return ServiceResult<User>.Fail($"Database error: {ex.Message}");
                }
            }
            catch (Exception ex)
            {
                return ServiceResult<User>.Fail($"Unexpected error: {ex.Message}");
            }
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

        private User? CheckIfUserAllreadyExists(string username, string email)
        {
            return _db.Users.FirstOrDefault(u => u.Username == username || u.Email == email);
        }
        #endregion


    }
}
