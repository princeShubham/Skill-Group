using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Skill_Group.Models
{
    public class DashBoardDbContext : DbContext
    {
        public DbSet<SkillGroup> SkillGroups { get; set; }
    }
}