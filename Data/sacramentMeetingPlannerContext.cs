using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using sacramentMeetingPlanner.Models;

namespace sacramentMeetingPlanner.Data {

    public class sacramentMeetingPlannerContext : DbContext
    {
        public sacramentMeetingPlannerContext (DbContextOptions<sacramentMeetingPlannerContext> options)
            : base(options)
        {
        }

        public DbSet<SacramentMeeting>? SacramentMeeting { get; set; }

        public DbSet<Speaker>? Speaker { get; set; }

        public DbSet<Hymn>? Hymn { get; set; }

        public DbSet<Bishopric>? Bishopric { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SacramentMeeting>().ToTable("SacramentMeeting");
            modelBuilder.Entity<Speaker>().ToTable("Speaker");
            modelBuilder.Entity<Bishopric>().ToTable("Bishopric");
            modelBuilder.Entity<Hymn>().ToTable("Hymn");
        }
    }
}