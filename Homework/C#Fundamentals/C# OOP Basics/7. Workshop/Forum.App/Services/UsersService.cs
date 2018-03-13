using Forum.Data;
using Forum.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static Forum.App.Controllers.SignUpController;

namespace Forum.App.Services
{
    public static class UsersService
    {
        public static SignUpStatus TrySignUpUser(string username, string password)
        {
            var validUsername = !string.IsNullOrWhiteSpace(username) && username.Length > 3;
            var validPassword = !string.IsNullOrWhiteSpace(password) && password.Length > 3;

            if (!validUsername || !validPassword)
            {
                return SignUpStatus.DetailsError;
            }

            var forumData = new ForumData();

            var userAlreadyExists = forumData.Users.Any(u => u.Username == username);

            if (!userAlreadyExists)
            {
                var id = forumData.Users.LastOrDefault()?.Id + 1 ?? 1;
                var user = new User(id, username, password, new List<int>());
                forumData.Users.Add(user);
                forumData.SaveChanges();
                return SignUpStatus.Success;
            }
            return SignUpStatus.UsernameTakenError;
        }

        public static bool TryLogInUser(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                return false;
            }

            var forumData = new ForumData();
            var userExists = forumData.Users.Any(u => u.Username == username && u.Password == password);
            return userExists;
        }

        public static User GetUser(int id)
        {
            var forumData = new ForumData();
            var user = forumData.Users.Single(u => u.Id == id);
            return user;
        }

        public static User GetUser(string username, ForumData forumData)
        {
            var user = forumData.Users.Single(u => u.Username == username);
            return user;
        }
    }
}
