using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;
using System.Text;
using ASP_Example.Models;

namespace ASP_Example.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly BlogDBContext blogDBContext;
        public UserController(BlogDBContext _blogDBContext)
        {
            blogDBContext = _blogDBContext;
        }

        [HttpGet]
        [Route("/CreateUsers")]
        public ActionResult createUser()
        {
            List<User> UsersList = new List<User>();
            User user1 = new User();
            User user2 = new User();
            User user3 = new User();
            User user4 = new User();
            User user5 = new User();


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

            blogDBContext.Users.AddRange(UsersList);
            blogDBContext.SaveChanges();

            // UsersList.Add(new User(Guid.NewGuid(), "Emmanuel@gmail.com", "09037268917", BCrypt.Net.BCrypt.HashPassword("emma123"), DateTime.Now, DateTime.Now));
            // UsersList.Add(new User(Guid.NewGuid(), "prosper@gmail.com", "08176388293", BCrypt.Net.BCrypt.HashPassword("prsoper123"), DateTime.Now, DateTime.Now));
            // UsersList.Add(new User(Guid.NewGuid(), "ifeanyi@gmail.com", "07026262917", BCrypt.Net.BCrypt.HashPassword("ifeanyi123"), DateTime.Now, DateTime.Now));
            // UsersList.Add(new User(Guid.NewGuid(), "favour@gmail.com", "08137123917", BCrypt.Net.BCrypt.HashPassword("favour123"), DateTime.Now, DateTime.Now));
            // UsersList.Add(new User(Guid.NewGuid(), "precious@gmail.com", "09177268916", BCrypt.Net.BCrypt.HashPassword("precious123"), DateTime.Now, DateTime.Now));
            // UsersList.Add(new User(Guid.NewGuid(), "Samuel@gmail.com", "09048368971", BCrypt.Net.BCrypt.HashPassword("samuel123"), DateTime.Now, DateTime.Now));
            return Ok(UsersList);
        }

        [HttpGet]
        [Route("/Users")]
        public ActionResult getUsers()
        {
            var users = blogDBContext.Users.ToList();
            int count = 0;
            foreach (var item in users)
            {
                count = count+1;
            }
            var dusers = new {
                user = users,
                length = count,
            };

            return Ok(dusers);
        }

        [HttpGet]
        [Route("/getUsers/{id}")]
        public ActionResult getSingleUsers([FromRoute] string id)
        {
            var users = blogDBContext.Users.Find(id);

            return Ok(users);
        }

        [HttpDelete]
        [Route("/getUsers/{id}/delete")]
        public ActionResult deleteUser([FromRoute] string id)
        {
            var User = blogDBContext.Users.Find(id);
            if (User is not null)
            {
                blogDBContext.Users.Remove(User!);
                blogDBContext.SaveChanges();

                return NoContent();
            }
            return BadRequest();
        }

        [HttpPut]
        [Route("/User/{id}/edit")]
        public ActionResult updateUser([FromRoute] string id)
        {
            try
            {
                var user = blogDBContext.Users.Find(id);
                if (user != null)
                {
                    user.Email = "newemail@gmail.com";
                    user.UserName = "newusername";
                    user.PhoneNumber = "newNumber";
                    user.updated_at = DateTime.Now;

                    blogDBContext.Users.Append(user);
                    blogDBContext.SaveChanges();

                    return Ok(user);
                }
                return NotFound();
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}