using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalR_ChartProject.API.Models
{
    public class ProjectContext:DbContext
    {
        public ProjectContext(DbContextOptions<ProjectContext> options):base(options)
        {

        }
        public DbSet<Covid> Covids { get; set; }
    }
}
