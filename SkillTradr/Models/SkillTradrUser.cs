using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace SkillTradr.Models
{
    public class SkillTradrUser : IdentityUser<int>
    {
        public DateTime CreatedOn { get; set; }

        public ICollection<Project> Projects { get; set; }

        public ICollection<UserSkill> UserSkills { get; set; }
    }
}
