using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeadraMustFall.Model.Domains
{
    public class CraftingMats
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool IsCPItem { get; set; }
        public CraftingDisciplines Discipline { get; set; }
        public List<ItemNames> ItemCategories { get; set; }

        public string LevelRange { get; set; }
    }
}
