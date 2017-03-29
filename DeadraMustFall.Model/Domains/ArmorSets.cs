using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeadraMustFall.Model.enums;

namespace DeadraMustFall.Model.Domains
{
    public class ArmorSets
    {
        public Guid Id { get; set; }
        public string SetName { get; set; }
        public ArmorTypes ArmorType { get; set; }
        public List<SetBonus> Bonus { get; set; }
        public int AmountNeededForFullSet { get; set; }
        public string FullSetBonusDescription { get; set; }

    }
}
