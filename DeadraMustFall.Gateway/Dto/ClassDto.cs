using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DeadraMustFall.Gateway.Dto
{
    public class ClassDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<SkillsDto> Skills { get; set; }
    }
}
