using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;
using System.Text;

namespace ASP_Example.Controllers
{
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        [Route("/getUsers")]
        public ActionResult getallUser()
        {
            List<User> UsersList = new List<User>();
            User user1 = new User();
            User user2 = new User();
            User user3 = new User();
            User user4 = new User();
            User user5 = new User();

            user1.id =Guid.NewGuid();
            user2.id =Guid.NewGuid();
            user3.id =Guid.NewGuid();
            user4.id =Guid.NewGuid();
            user5.id =Guid.NewGuid();

            user1.Email = "Emmanuel@gmail.com";
            user2.Email = "prosper@gmail.com";
            user3.Email = "ifeanyi@gmail.com";
            user4.Email = "favour@gmail.com";
            user5.Email = "precious@gmail.com";

            user1.Tell = "09037268917";
            user2.Tell = "08176388293";
            user3.Tell = "07026262917";
            user4.Tell = "08137123917";
            user5.Tell = "09177268916";

            user1.Password = BCrypt.Net.BCrypt.HashPassword("emma123");
            user2.Password = BCrypt.Net.BCrypt.HashPassword("prsoper123");
            user3.Password = BCrypt.Net.BCrypt.HashPassword("ifeanyi123");
            user4.Password = BCrypt.Net.BCrypt.HashPassword("favour123");
            user5.Password = BCrypt.Net.BCrypt.HashPassword("precious123");

            user1.created_at = DateTime.Now;
            user2.created_at = DateTime.Now;
            user3.created_at = DateTime.Now;
            user4.created_at = DateTime.Now;
            user5.created_at = DateTime.Now;

            user1.updated_at = DateTime.Now;
            user2.updated_at = DateTime.Now;
            user3.updated_at = DateTime.Now;
            user4.updated_at = DateTime.Now;
            user5.updated_at = DateTime.Now;

            UsersList.Add(user1);
            UsersList.Add(user2);
            UsersList.Add(user3);
            UsersList.Add(user4);
            UsersList.Add(user5);

            // UsersList.Add(new User(Guid.NewGuid(), "Emmanuel@gmail.com", "09037268917", BCrypt.Net.BCrypt.HashPassword("emma123"), DateTime.Now, DateTime.Now));
            // UsersList.Add(new User(Guid.NewGuid(), "prosper@gmail.com", "08176388293", BCrypt.Net.BCrypt.HashPassword("prsoper123"), DateTime.Now, DateTime.Now));
            // UsersList.Add(new User(Guid.NewGuid(), "ifeanyi@gmail.com", "07026262917", BCrypt.Net.BCrypt.HashPassword("ifeanyi123"), DateTime.Now, DateTime.Now));
            // UsersList.Add(new User(Guid.NewGuid(), "favour@gmail.com", "08137123917", BCrypt.Net.BCrypt.HashPassword("favour123"), DateTime.Now, DateTime.Now));
            // UsersList.Add(new User(Guid.NewGuid(), "precious@gmail.com", "09177268916", BCrypt.Net.BCrypt.HashPassword("precious123"), DateTime.Now, DateTime.Now));
            // UsersList.Add(new User(Guid.NewGuid(), "Samuel@gmail.com", "09048368971", BCrypt.Net.BCrypt.HashPassword("samuel123"), DateTime.Now, DateTime.Now));
            return Ok(UsersList);
        }
    }   
}