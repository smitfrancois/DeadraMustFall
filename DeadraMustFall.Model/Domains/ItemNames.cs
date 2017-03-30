using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeadraMustFall.Model.Domains
{
    public class ItemNames
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Item> Items { get; set; }
        public CraftingMats Mat { get; set; }
        public ItemTypes TypeOfItem { get; set; }
    }
}
