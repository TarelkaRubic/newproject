using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using newprojectapi.Models;
using Microsoft.EntityFrameworkCore;

namespace newprojectapi.Contexts
{
    public class UserContext: DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        
    }
}
