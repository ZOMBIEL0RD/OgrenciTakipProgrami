using Microsoft.EntityFrameworkCore;
using Nesne_2_OGRENCI_TAKIP_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nesne_2_OGRENCI_TAKIP_1.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Register> Registers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=.;initial catalog=DbOGRTAKIP;user id=sa; password=STARLORD;TrustServerCertificate=True");
        }
    }
}
