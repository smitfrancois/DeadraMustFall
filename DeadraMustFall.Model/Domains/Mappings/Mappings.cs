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

   internal class SkillLineMap : EntityTypeConfiguration<SkillLines>
    {
        public SkillLineMap()
        {
            HasKey(x => x.Id);
            ToTable("SkillLines");
        }
    }

    internal class SkillLineCategoryMap : EntityTypeConfiguration<SkillLineCategories>
    {
        public SkillLineCategoryMap()
        {
            HasKey(x => x.Id);
            ToTable("SkillLineCategories");
            HasMany(x => x.SkillLines).WithRequired(x => x.SkillCategory);
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

    internal class ItemNamesMap : EntityTypeConfiguration<ItemNames>
    {
        public ItemNamesMap()
        {
            HasKey(x => x.Id);
            ToTable("ItemNames");

            HasMany(x => x.Items).WithRequired(x => x.Name);
            HasRequired(x => x.Mat).WithMany(x => x.ItemCategories);

        }
    }

    internal class ItemCategoryMap : EntityTypeConfiguration<ItemCategory>
    {
        public ItemCategoryMap()
        {
            HasKey(x => x.Id);
            ToTable("ItemCategories");
            HasMany(x => x.ItemTypes).WithRequired(x => x.Category);
        }
    }

    internal class ItemQualityMap : EntityTypeConfiguration<ItemQuality>
    {
        public ItemQualityMap()
        {
            HasKey(x => x.Id);
            ToTable("ItemQuality");
            HasMany(x => x.Items).WithRequired(x => x.Quality);
        }
    }

    internal class CraftingDisciplinesMap : EntityTypeConfiguration<CraftingDisciplines>
    {
        public CraftingDisciplinesMap()
        {
            HasKey(x => x.Id);
            ToTable("CraftingDisciplines");

        }
    }

    internal class CraftingMatsMap : EntityTypeConfiguration<CraftingMats>
    {
        public CraftingMatsMap()
        {
            HasKey(x => x.Id);
            ToTable("CraftingMaterials");

            HasRequired(x => x.Discipline).WithMany(x => x.Materials);
        }
    }

    internal class ItemTypesMap : EntityTypeConfiguration<ItemTypes>
    {
        public ItemTypesMap()
        {
            HasKey(x => x.Id);
            ToTable("ItemTypes");
            HasMany(x => x.ItemCategories).WithRequired(x => x.TypeOfItem);

        }
    }
}
