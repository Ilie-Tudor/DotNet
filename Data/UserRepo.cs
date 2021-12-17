using System.Collections.Generic;
using ReviewApp.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ReviewApp.Data{


    public class UserRepo : IUserRepo{

        AplicationContext _dbCtx;
        public UserRepo(AplicationContext dbCtx)
        {
            _dbCtx = dbCtx;
        }
        public IEnumerable<User> GetAllUsers(){
            return _dbCtx.Users.ToList();
        }
        public User GetUserById(string id){

            User user = _dbCtx.Users.FirstOrDefault(p=>p.user_id==id);
            return user;
        }

        public void CreateUser(User newUser){
            _dbCtx.Users.Add(newUser);
            _dbCtx.SaveChanges();
        }

        public void UpdateUser(User updatedUser){
            var upd_user = _dbCtx.Users.FirstOrDefault(p=>p.user_id==updatedUser.user_id);
            if(upd_user != null){
                upd_user = updatedUser;
                _dbCtx.SaveChanges();
            }
        }

        public void DeleteUserById(string id){
            User del_user = _dbCtx.Users.FirstOrDefault(p=>p.user_id==id);
            if(del_user != null){
                _dbCtx.Users.Remove(del_user);
                _dbCtx.SaveChanges();
            }
        }
    }
}