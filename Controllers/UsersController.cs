using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ReviewApp.Models;
using ReviewApp.Data;

namespace ReviewApp.Controllers
{
    
    [Route("api/users")]
    [ApiController]
    public class UsersController:ControllerBase{
        private readonly IUserRepo _repository;

        public UsersController(IUserRepo  repository){
            _repository = repository;
        }
        

        [HttpGet]
        public ActionResult<IEnumerable<User>> GetAllUsers(){

            var usersList = _repository.GetAllUsers();

            return Ok(usersList);
            
        }
        

        [HttpGet("{id}")]
        public ActionResult<User> GetUserById(string id){
            var user = _repository.GetUserById(id);
            return Ok(user);
        }


        [HttpPost]
        public ActionResult<string> CreateUser(User newUser){
            _repository.CreateUser(newUser);
            return Ok(newUser);
        }

        [HttpPut]
        public ActionResult<string> UpdateUser(User updatedUser){
            _repository.UpdateUser(updatedUser);
            return Ok(updatedUser);
        }

        [HttpDelete("{id}")]
        public ActionResult<string> DeleteUserById(string id){
            _repository.DeleteUserById(id);
            return Ok(id);
        }
    }
}