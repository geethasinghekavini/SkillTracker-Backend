using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using SkillTrackr.Domain.Entities;


public class SkillTrackrDbContext : DbContext
{
    public SkillTrackrDbContext(DbContextOptions<SkillTrackrDbContext> options) : base(options) { }

    public DbSet<Skill> Skills { get; set; }
    public DbSet<ProgressLog> ProgressLogs { get; set; }
}