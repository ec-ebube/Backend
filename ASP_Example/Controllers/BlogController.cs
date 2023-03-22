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
    public class BlogController : ControllerBase
    {
        private readonly BlogDBContext blogDBContext;
        public BlogController(BlogDBContext _blogDBContext)
        {
            blogDBContext = _blogDBContext;
        }

        [HttpGet]
        [Route("/getBlog")]
        public ActionResult createBlog()
        {
            List<Blog> BlogList = new List<Blog>();
            Blog blog1 = new Blog();
            Blog blog2 = new Blog();
            Blog blog3 = new Blog();
            Blog blog4 = new Blog();
            Blog blog5 = new Blog();

            blog1.id = Guid.NewGuid();
            blog2.id = Guid.NewGuid();
            blog3.id = Guid.NewGuid();
            blog4.id = Guid.NewGuid();
            blog5.id = Guid.NewGuid();

            blog1.text = "";
            blog2.text = "";
            blog3.text = "";
            blog4.text = "";
            blog5.text = "";

            blog1.Title = "Mission";
            blog2.Title = "Adventure";
            blog3.Title = "Legend";
            blog4.Title = "Myth";
            blog5.Title = "Folk";

            blog1.Created_at = DateTime.Now;
            blog2.Created_at = DateTime.Now;
            blog3.Created_at = DateTime.Now;
            blog4.Created_at = DateTime.Now;
            blog5.Created_at = DateTime.Now;

            blog1.Updated_at = DateTime.Now;
            blog2.Updated_at = DateTime.Now;
            blog3.Updated_at = DateTime.Now;
            blog4.Updated_at = DateTime.Now;
            blog5.Updated_at = DateTime.Now;

            BlogList.Add(blog1);
            BlogList.Add(blog2);
            BlogList.Add(blog3);
            BlogList.Add(blog4);
            BlogList.Add(blog5);

            return Ok(BlogList);

        }

        [HttpGet]
        [Route("/Blog")]
        public ActionResult getBlog()
        {
            var blogs = blogDBContext.Blogs.ToList();
            int count = 0;
            foreach (var item in blogs)
            {
                count = count+1;
            }
            var dblogs = new {
                blog = blogs,
                length = count,
            };

            return Ok(dblogs);
        }

        [HttpGet]
        [Route("/getBlog/{id}")]
        public ActionResult getSingleBlog([FromRoute] string id)
        {
            var blogs = blogDBContext.Blogs.Find(id);

            return Ok(blogs);
        }

        [HttpDelete]
        [Route("/getBlog/{id}/delete")]
        public ActionResult deleteBlog([FromRoute] string id)
        {
            var Blog = blogDBContext.Blogs.Find(id);
            if (Blog is not null)
            {
                blogDBContext.Blogs.Remove(Blog!);
                blogDBContext.SaveChanges();

                return NoContent();
            }
            return BadRequest();
        }

        [HttpPut]
        [Route("/Blog/{id}/edit")]
        public ActionResult updateBlog([FromRoute] string id)
        {
            try
            {
                var blog = blogDBContext.Blogs.Find(id);
                if (blog != null)
                {
                    blog.text = "Any text";
                    blog.Title = "Any Title";
                    blog.Updated_at = DateTime.Now;

                    blogDBContext.Blogs.Append(blog);
                    blogDBContext.SaveChanges();

                    return Ok(blog);
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