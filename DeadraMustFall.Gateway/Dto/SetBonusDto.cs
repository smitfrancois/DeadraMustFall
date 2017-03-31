using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeadraMustFall.Gateway.Dto;

namespace DeadraMustFall.Gateway.Dto
{
    public class SetBonusDto
    {
        public Guid Id { get; set; }
        public int NumberOfItems { get; set; }
        public string BonusTypeApplied { get; set; }
        public int AmountApplied { get; set; }
        public ArmorSetsDto ArmorSet { get; set; }
    }
}
