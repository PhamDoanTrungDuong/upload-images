using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pratice.CSharp.UploadImage.Models
{
    public class ImageDbContext : DbContext
    {
        public ImageDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<ImageModel> Images { get; set; }
    }
}
