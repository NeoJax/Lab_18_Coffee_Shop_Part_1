using System;
using Lab_18_Coffee_Shop_Part_1.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab_18_Coffee_Shop_Part_1.Models
{
    public class UserDbContext : DbContext
    {
        public UserDbContext()
        {
        }

        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
		{
        }

        public DbSet<User> Users { get; set; }
    }
}
