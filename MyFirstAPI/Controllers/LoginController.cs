using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyFirstAPI.Controllers
{
    public class LoginController : ApiController
    {
        [HttpGet]
        [Route("api/login/{emailId}/{password}")]
        public UserCredential Login(string emailId,string password)
        {
           return GetUserCredentials().Where(x => x.EmailId == emailId && x.Password == password).FirstOrDefault();
        }

        [HttpGet]
        [Route("api/login/{id}")]
        public UserModel GetUserInfo(int id)
        {
           return GetAllUsers().Where(x => x.Id == id).FirstOrDefault();
        }
        private List<UserModel> GetAllUsers()
        {
            List<UserModel> users = new List<UserModel>();
            users.Add(new UserModel() { Id = 1, Age=19, FirstName = "Rohit", LastName = "Ramesh", EmailId = "rohit@bts.com", Role = "User" });
            users.Add(new UserModel() { Id = 2, Age=20,FirstName = "Mughil", LastName = "Suresh", EmailId = "mughil@bts.com", Role = "User" });
            users.Add(new UserModel() { Id = 3, Age=23,FirstName = "Vishnu", LastName = "Saravanan", EmailId = "vishnu@bts.com", Role = "Admin" });
            users.Add(new UserModel() { Id = 4, Age = 35, FirstName = "Vivek", LastName = "Anbu", EmailId = "vivek@bts.com", Role = "Admin" });
            return users;
        }

        private List<UserCredential> GetUserCredentials()
        {
            List<UserCredential> userCredentials = new List<UserCredential>();
            userCredentials.Add(new UserCredential() { Id = 1, Password = "rohit", EmailId = "rohit@bts.com",  Role = "User" });
            userCredentials.Add(new UserCredential() { Id = 2, Password = "mughil", EmailId = "mughil@bts.com", Role = "User" });
            userCredentials.Add(new UserCredential() { Id = 3, Password = "vishnu", EmailId = "vishnu@bts.com", Role = "Admin" });
            userCredentials.Add(new UserCredential() { Id = 4, Password = "vivek", EmailId = "vivek@bts.com", Role = "Admin" });
            userCredentials.Add(new UserCredential() { Id = 4, Password = "vinith", EmailId = "vinith@bts.com", Role = "Admin" });
            return userCredentials;
        }
    }

    public class UserCredential
    {
        public int Id { get; set; }
        public string EmailId { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
    public class UserModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailId { get; set; }
        public int Age { get; set; }
        public DateTime DOB { get; set; }
        public string Role { get; set; }
        public string[] IntrestedAreas { get; set; }
    }
}
