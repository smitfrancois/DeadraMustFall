using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeadraMustFall.Model.enums;

namespace DeadraMustFall.Model.Domains
{
    public class Skills
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Unlocks { get; set; }
        public string Costs { get; set; }
        public string CastTime { get; set; }
        public string RadiusRange { get; set; }
        public SkillType SkillType { get; set; }
        public bool IsMorph { get; set; }
        public Class ClassSkillsBelongTo { get; set; }
        public Skills ParentOfMorph { get; set; }
        public List<Skills> Morphs { get; set; }

    }
}
