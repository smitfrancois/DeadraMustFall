using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeadraMustFall.Model.Domains
{
    public class CraftingDisciplines
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public List<CraftingMats> Materials { get; set; }
    }
}
