using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using coreMvcWeb.Models;

namespace coreMvcWeb.Data
{
    public class coreMvcWebContext : DbContext
    {
        public coreMvcWebContext (DbContextOptions<coreMvcWebContext> options)
            : base(options)
        {
        }

        public DbSet<coreMvcWeb.Models.User> User { get; set; } = default!;
    }
}
