using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ASP_Example.Models
{
    public class BlogDBContext : DbContext
    {
        public BlogDBContext(DbContextOptions<BlogDBContext> options) : base(options)
        {
            
        }
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Blog> Blogs { get; set; } = null!;
    }
}