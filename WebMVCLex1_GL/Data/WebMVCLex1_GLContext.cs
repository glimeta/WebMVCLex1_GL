using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebMVCLex1_GL.Models;

namespace WebMVCLex1_GL.Data
{
    public class WebMVCLex1_GLContext : DbContext
    {
        public WebMVCLex1_GLContext (DbContextOptions<WebMVCLex1_GLContext> options)
            : base(options)
        {
        }

        public DbSet<WebMVCLex1_GL.Models.Car> Car { get; set; } = default!;
        public DbSet<Customer> Customers { get; set; }
    }
}
