using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeadraMustFall.Model.Domains
{
    public class Skill
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Unlocks { get; set; }
        public string Cost { get; set; }
        public string CastTime { get; set; }
        public string RadiusRange { get; set; }
        public bool IsMorph { get; set; }

        public Skill ParentSkill { get; set; }
        public List<Skill> Morphs { get; set; }
        public SkillLines SkillLine { get; set; }
        public SkillType SkillType { get; set; }
    }
}
