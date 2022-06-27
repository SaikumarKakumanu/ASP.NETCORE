using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC_Student.Models;

namespace MVC_Student.Data
{
    public class MVC_StudentContext : DbContext
    {
        public MVC_StudentContext (DbContextOptions<MVC_StudentContext> options)
            : base(options)
        {
        }

        public DbSet<MVC_Student.Models.Student>? Student { get; set; }
    }
}
