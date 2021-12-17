using System.Collections.Generic;
using ReviewApp.Models;

namespace ReviewApp.Data{


    public interface IUserRepo{
        IEnumerable<User> GetAllUsers();
        User GetUserById(string id);
        void CreateUser(User newUser);
        void UpdateUser(User updatedUser);
        void DeleteUserById(string id);
    }
}