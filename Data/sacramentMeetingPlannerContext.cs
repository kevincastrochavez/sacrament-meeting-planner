using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using sacramentMeetingPlanner.Models;

    public class sacramentMeetingPlannerContext : DbContext
    {
        public sacramentMeetingPlannerContext (DbContextOptions<sacramentMeetingPlannerContext> options)
            : base(options)
        {
        }

        public DbSet<sacramentMeetingPlanner.Models.SacramentMeeting>? SacramentMeeting { get; set; }

        public DbSet<sacramentMeetingPlanner.Models.Speaker>? Speaker { get; set; }
    }
