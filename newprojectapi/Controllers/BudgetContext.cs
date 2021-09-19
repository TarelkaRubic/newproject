using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using newprojectapi.Models;

namespace newprojectapi.Controllers
{
    public class BudgetContext : DbContext
    {
        public BudgetContext(DbContextOptions<BudgetContext> options)
            : base(options)
        {
        
        }
        public DbSet<Budget> Budgets { get; set; }
    }
}
