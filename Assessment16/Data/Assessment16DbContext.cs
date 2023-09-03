using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Assessment16.Models;

namespace Assessment16.Data
{
    public class Assessment16DbContext : DbContext
    {
        public Assessment16DbContext (DbContextOptions<Assessment16DbContext> options)
            : base(options)
        {
        }

        public DbSet<Assessment16.Models.Task> Task { get; set; } = default!;
    }
}
