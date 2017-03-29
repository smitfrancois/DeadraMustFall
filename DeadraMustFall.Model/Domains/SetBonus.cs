using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeadraMustFall.Model.Domains
{
    public class SetBonus
    {
        public Guid Id { get; set; }
        public int NumberOfItems { get; set; }
        public string BonusTypeApplied { get; set; }
        public int AmountApplied { get; set; }
        public ArmorSets ArmorSet { get; set; }

    }
}
