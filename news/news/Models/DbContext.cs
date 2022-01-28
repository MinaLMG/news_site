using Microsoft.EntityFrameworkCore;
using news.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace news.Data
{
    public class newsContext : DbContext
    {
        public newsContext(DbContextOptions<newsContext> options)
            : base(options)
        {
        }
        public DbSet<category> categories { get; set; }
        public DbSet<contactUs> contacts { get; set; }
        public DbSet<News> news { get; set; }
        public DbSet<teamMember> teamMembers { get; set; }


    }
}
