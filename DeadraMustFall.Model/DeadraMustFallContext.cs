using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeadraMustFall.Model.Domains;
using DeadraMustFall.Model.Domains.Mappings;

namespace DeadraMustFall.Model
{
    public class DeadraMustFallContext:DbContext
    {
        public DeadraMustFallContext() : base("name=DeadraMustFallDBConnectionString")
        {


            //Database.SetInitializer<DeadraMustFallContext>(new DropCreateDatabaseIfModelChanges<DeadraMustFallContext>());
            Database.SetInitializer(new DeadraMustFallInitializer());
            Database.Initialize(true);
            
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemNames> ItemNames { get; set; }
        public DbSet<ItemCategory> ItemCategories { get; set; }
        public DbSet<ItemQuality> ItemQualities { get; set; }
        public DbSet<CraftingDisciplines> CraftingDisciplines { get; set; }
        public DbSet<CraftingMats> CraftingMaterials { get; set; }
        public DbSet<ItemTypes> ItemTypes { get; set; }
        public DbSet<Race> Races { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<SkillLines> SkillLines { get; set; }
        public DbSet<SkillLineCategories> SkillLineCategories { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new ItemMap());
            modelBuilder.Configurations.Add(new ItemNamesMap());
            modelBuilder.Configurations.Add(new ItemCategoryMap());
            modelBuilder.Configurations.Add(new ItemQualityMap());
            modelBuilder.Configurations.Add(new CraftingDisciplinesMap());
            modelBuilder.Configurations.Add(new CraftingMatsMap());
            modelBuilder.Configurations.Add(new ItemTypesMap());
            modelBuilder.Configurations.Add(new RaceMap());
            modelBuilder.Configurations.Add(new ClassMap());
            modelBuilder.Configurations.Add(new SkillLineMap());
            modelBuilder.Configurations.Add(new SkillLineCategoryMap());
            //base.OnModelCreating(modelBuilder);
        }
    }
}
