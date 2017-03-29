using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeadraMustFall.Model.enums;

namespace DeadraMustFall.Model.Domains
{
    public class Item
    {
        public Guid Id { get; set; }
        public ItemTypes ItemType { get; set; }
        public string Name { get; set; }
        public ItemQuality Quality { get; set; }
    }
}
