using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyFirstAppWeb.Models;

namespace MyFirstAppWeb.Data
{
    public class MyFirstAppWebContext : DbContext
    {
        public MyFirstAppWebContext (DbContextOptions<MyFirstAppWebContext> options)
            : base(options)
        {
        }

        public DbSet<MyFirstAppWeb.Models.Vendedor> Vendedor { get; set; } = default!;
    }
}
