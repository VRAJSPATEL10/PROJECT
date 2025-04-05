using System.Collections.Generic;
using UserManagementAPI.Models;

namespace UserManagementAPI.Services
{
    public class UserService
    {
        private readonly List<User> _users = new List<User>();

        public List<User> GetAllUsers() => _users;

        public User GetUserById(int id) => _users.Find(user => user.Id == id);

        public void CreateUser(User user)
        {
            user.Id = _users.Count + 1; // Simple ID assignment logic
            _users.Add(user);
        }

        public void UpdateUser(int id, User user)
        {
            var existingUser = _users.Find(u => u.Id == id);
            if (existingUser != null)
            {
                existingUser.Name = user.Name;
                existingUser.Email = user.Email;
                existingUser.Password = user.Password;
            }
        }

        public void DeleteUser(int id)
        {
            var user = _users.Find(u => u.Id == id);
            if (user != null)
            {
                _users.Remove(user);
            }
        }
    }
}
