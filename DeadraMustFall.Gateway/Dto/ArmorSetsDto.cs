using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeadraMustFall.Model.Domains;
using DeadraMustFall.Model.enums;

namespace DeadraMustFall.Gateway.Dto
{
    public class ArmorSetsDto
    {
        public Guid Id { get; set; }
        public string SetName { get; set; }
        public ArmorTypes ArmorType { get; set; }
        public List<SetBonusDto> Bonus { get; set; }
        public int AmountNeededForFullSet { get; set; }
        public string FullSetBonusDescription { get; set; }
    }
}
