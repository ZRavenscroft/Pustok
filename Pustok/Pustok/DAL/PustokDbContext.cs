﻿using Microsoft.EntityFrameworkCore;
using Pustok.Models;
using System.Security.Cryptography.X509Certificates;

namespace Pustok.DAL
{
    public class PustokDbContext:DbContext
    {
        public PustokDbContext(DbContextOptions<PustokDbContext> options):base(options)
        {
            
        }

        public DbSet<Genres> Genres { get; set; }
        public DbSet<Authors> Authors { get; set; }
        public DbSet<Books> Books { get; set; }
        public DbSet<BtmPromotions> BtmPromotions { get; set; }
        public DbSet<Sliders> Sliders { get; set; }
        public DbSet<TopPromotions> TopPromotions { get; set; }
    }
}
