using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ClinetWebApplication.Models;

namespace ClinetWebApplication.Data
{
    public class ClinetWebApplicationContext : DbContext
    {
        public ClinetWebApplicationContext (DbContextOptions<ClinetWebApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<ClinetWebApplication.Models.Employee> Employee { get; set; }
    }
}
