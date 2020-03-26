using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Model.Entities;

namespace SGA.Models
{
    public class SGAContext : DbContext
    {
        public SGAContext (DbContextOptions<SGAContext> options)
            : base(options)
        {
        }

        public DbSet<Model.Entities.Shop> Shop { get; set; }
    }
}
