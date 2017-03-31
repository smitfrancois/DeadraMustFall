using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeadraMustFall.Model.Domains
{
    public class ItemTypes
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public CraftingDisciplines Discipline { get; set; }
        public ItemCategory Category { get; set; }
        public List<ItemNames> ItemCategories { get; set; }
    }
}
