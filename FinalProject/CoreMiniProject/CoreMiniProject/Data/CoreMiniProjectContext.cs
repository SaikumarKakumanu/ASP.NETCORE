using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CoreMiniProject.Models;

namespace CoreMiniProject.Data
{
    public class CoreMiniProjectContext : DbContext
    {
        public CoreMiniProjectContext (DbContextOptions<CoreMiniProjectContext> options)
            : base(options)
        {
        }

        public DbSet<CoreMiniProject.Models.Product> Product { get; set; }
    }
}
