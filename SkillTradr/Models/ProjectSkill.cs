using System.ComponentModel.DataAnnotations;

namespace SkillTradr.Models
{
    public class ProjectSkill
    {
        public int Id { get; set; }

        [Required]
        public Project Project { get; set; }
        public int ProjectId { get; set; }

        [Required]
        public Skill Skill { get; set; }
        public int SkillId { get; set; }

        public bool Needed { get; set; }
    }
}
