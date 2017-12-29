using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SkillTradr.Models
{
    public class Project
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public DateTime CreatedOn { get; set; }

        [Required]
        public SkillTradrUser SkillTradrUser { get; set; }
        [Column("UserId")]
        public int SkillTradrUserId { get; set; }

        public ICollection<ProjectSkill> ProjectSkills { get; set; }
    }
}
