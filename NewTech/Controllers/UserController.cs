using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NewTech.Core.Interface;
using NewTech.Core.Model;

namespace NewTech.Controllers
{
    [Produces("application/json")]
    [Route("api/User")]
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;
        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        [Route("AllUsers")]
        public IEnumerable<User> GetAll()
        {
            return _userRepository.GetAllUsers();
            //return Core.DbInitializer.GetManufacturerSampleData();
        }
        [Route("GetById")]
        public User GetUserById(string id)
        {
            return _userRepository.GetUserById(id).FirstOrDefault();
        }
        [Route("GetByFName")]
        public User GetUserByFName(string fName)
        {
            return _userRepository.GetUserByFName(fName).FirstOrDefault();
        }
        [Route("GetByLName")]
        public User GetUserByLName(string lName)
        {
            return _userRepository.GetUserByLName(lName).FirstOrDefault();
        }
        public void Delete(string id)
        {
            var user = _userRepository.GetUserById(id).FirstOrDefault();
            _userRepository.Delete(user);
        }
        public void CreateUser(User user)
        {
            _userRepository.Create(user);
        }
        public void UpdateManufacturer(User manufacturer)
        {
            _userRepository.Update(manufacturer);
        }
    }
}