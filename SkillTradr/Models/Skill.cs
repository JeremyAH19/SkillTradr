using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SkillTradr.Models
{
    public class Skill
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        public ICollection<ProjectSkill> ProjectSkills { get; set; }

        public ICollection<UserSkill> UserSkills { get; set; }
    }
}
