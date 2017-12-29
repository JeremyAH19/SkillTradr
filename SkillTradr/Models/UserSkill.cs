using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SkillTradr.Models
{
    public class UserSkill
    {
        public int Id { get; set; }

        [Required]
        public SkillTradrUser SkillTradrUser { get; set; }

        [Column("UserId")]
        public int SkillTradrUserId { get; set; }

        [Required]
        public Skill Skill { get; set; }
        public int SkillId { get; set; }

        public int Experience { get; set; }
    }
}
