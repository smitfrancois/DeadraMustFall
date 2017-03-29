using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeadraMustFall.Model.Domains.Mappings
{
    internal class RaceMap : EntityTypeConfiguration<Race>
    {
        public RaceMap()
        {
            HasKey(x => x.Id);
            ToTable("Races");
            
        }
    }

    internal class ClassMap : EntityTypeConfiguration<Class>
    {
        public ClassMap()
        {
            HasKey(x => x.Id);
            ToTable("Classes");
        }
    }

    internal class SkillsMap : EntityTypeConfiguration<Skills>
    {
        public SkillsMap()
        {
            HasKey(x => x.Id);
            ToTable("Skills");

            HasOptional(x => x.ParentOfMorph).WithMany(x => x.Morphs);
        }
    }

    internal class ArmorSetMap : EntityTypeConfiguration<ArmorSets>
    {
        public ArmorSetMap()
        {
            HasKey(x => x.Id);
            ToTable("ArmorSets");

            HasMany(x => x.Bonus).WithRequired(x => x.ArmorSet);
        }
    }

    internal class ItemMap : EntityTypeConfiguration<Item>
    {
        public ItemMap()
        {
            HasKey(x => x.Id);
            ToTable("Items");

        }
    }
}
