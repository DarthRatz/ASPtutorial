using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SWCanon.Models
{
    public class SWCanonContext : DbContext
    {
        public SWCanonContext (DbContextOptions<SWCanonContext> options)
            : base(options)
        {
        }

        public DbSet<SWCanon.Models.Movie> Movie { get; set; }
    }
}
