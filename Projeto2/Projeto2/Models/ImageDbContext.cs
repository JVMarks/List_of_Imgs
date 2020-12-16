using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto2.Models
{
    public class ImageDbContext:DbContext
    {
        public ImageDbContext(DbContextOptions<ImageDbContext> options) : base(options)
        {

        }

        public DbSet<ImageModel> Images { get; set; }
    }
}
