using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MGasiorekHelloWorldMVC.Models;

namespace MGasiorekHelloWorldMVC.Data
{
    public class MGasiorekHelloWorldMVCContext : DbContext
    {
        public MGasiorekHelloWorldMVCContext (DbContextOptions<MGasiorekHelloWorldMVCContext> options)
            : base(options)
        {
        }

        public DbSet<MGasiorekHelloWorldMVC.Models.Animal> Animal { get; set; }
    }
}
