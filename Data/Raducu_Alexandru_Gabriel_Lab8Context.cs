using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Raducu_Alexandru_Gabriel_Lab8.Models;

namespace Raducu_Alexandru_Gabriel_Lab8.Data
{
    public class Raducu_Alexandru_Gabriel_Lab8Context : DbContext
    {
        public Raducu_Alexandru_Gabriel_Lab8Context (DbContextOptions<Raducu_Alexandru_Gabriel_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Raducu_Alexandru_Gabriel_Lab8.Models.Book> Book { get; set; }

        public DbSet<Raducu_Alexandru_Gabriel_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Raducu_Alexandru_Gabriel_Lab8.Models.Category> Category { get; set; }
    }
}
