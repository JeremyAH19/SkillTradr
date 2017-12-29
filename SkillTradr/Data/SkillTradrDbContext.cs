using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SkillTradr.Models;

namespace SkillTradr.Data
{
    public class SkillTradrDbContext : IdentityDbContext<SkillTradrUser, SkillTradrRole, int>
    {
        public DbSet<Project> Projects { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<ProjectSkill> ProjectSkills { get; set; }
        public DbSet<UserSkill> UserSkills { get; set; }

        public SkillTradrDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
