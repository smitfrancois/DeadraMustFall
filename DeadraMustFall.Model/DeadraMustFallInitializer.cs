using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeadraMustFall.Model.Domains;
using DeadraMustFall.Model.enums;

namespace DeadraMustFall.Model
{
    public class DeadraMustFallInitializer:DropCreateDatabaseIfModelChanges<DeadraMustFallContext>
    {
   
        protected override void Seed(DeadraMustFallContext context)
        {
            var craftingDisciplines = CreateCraftingDisciplines();
            var craftingMats = CreateCraftingMats(craftingDisciplines);
            var itemCategory = CreateItemCategories();
            var itemTypes = CreateItemTypes(itemCategory, craftingDisciplines);
            var qualities = CreateQualities();
            var names = CreateItemNames(itemTypes,craftingMats);
            var items = CreateWeapons(names, itemCategory, qualities);



            context.ItemTypes.AddRange(itemTypes);
            context.CraftingDisciplines.AddRange(craftingDisciplines);
            context.CraftingMaterials.AddRange(craftingMats);
            context.ItemQualities.AddRange(qualities);
            context.ItemCategories.AddRange(itemCategory);
            context.ItemNames.AddRange(names);
            context.Items.AddRange(items);
           
           

            base.Seed(context);
        }

        public List<ItemTypes> CreateItemTypes(List<ItemCategory> Categories,List<CraftingDisciplines> disciplines)
        {
            List<ItemTypes> itemTypes = new List<ItemTypes>();

            itemTypes.Add(new ItemTypes() { Id = Guid.NewGuid(), Name = "Axe",Category = Categories.FirstOrDefault(x => x.Name == "Weapon"),Discipline = disciplines.FirstOrDefault(x => x.Name == "Blacksmithing") });
            itemTypes.Add(new ItemTypes() { Id = Guid.NewGuid(), Name = "Sword", Category = Categories.FirstOrDefault(x => x.Name == "Weapon"), Discipline = disciplines.FirstOrDefault(x => x.Name == "Blacksmithing") });
            itemTypes.Add(new ItemTypes() { Id = Guid.NewGuid(), Name = "Mace", Category = Categories.FirstOrDefault(x => x.Name == "Weapon"), Discipline = disciplines.FirstOrDefault(x => x.Name == "Blacksmithing") });
            itemTypes.Add(new ItemTypes() { Id = Guid.NewGuid(), Name = "Dagger", Category = Categories.FirstOrDefault(x => x.Name == "Weapon"), Discipline = disciplines.FirstOrDefault(x => x.Name == "Blacksmithing") });
            itemTypes.Add(new ItemTypes() { Id = Guid.NewGuid(), Name = "Greatsword", Category = Categories.FirstOrDefault(x => x.Name == "Weapon"), Discipline = disciplines.FirstOrDefault(x => x.Name == "Blacksmithing") });
            itemTypes.Add(new ItemTypes() { Id = Guid.NewGuid(), Name = "Battle Axe", Category = Categories.FirstOrDefault(x => x.Name == "Weapon"), Discipline = disciplines.FirstOrDefault(x => x.Name == "Blacksmithing") });
            itemTypes.Add(new ItemTypes() { Id = Guid.NewGuid(), Name = "Maul", Category = Categories.FirstOrDefault(x => x.Name == "Weapon"), Discipline = disciplines.FirstOrDefault(x => x.Name == "Blacksmithing") });

            itemTypes.Add(new ItemTypes() { Id = Guid.NewGuid(), Name = "Cuirass", Category = Categories.FirstOrDefault(x => x.Name == "Armor"), Discipline = disciplines.FirstOrDefault(x => x.Name == "Blacksmithing") });
            itemTypes.Add(new ItemTypes() { Id = Guid.NewGuid(), Name = "Greaves", Category = Categories.FirstOrDefault(x => x.Name == "Armor"), Discipline = disciplines.FirstOrDefault(x => x.Name == "Blacksmithing") });
            itemTypes.Add(new ItemTypes() { Id = Guid.NewGuid(), Name = "Pauldrons", Category = Categories.FirstOrDefault(x => x.Name == "Armor"), Discipline = disciplines.FirstOrDefault(x => x.Name == "Blacksmithing") });
            itemTypes.Add(new ItemTypes() { Id = Guid.NewGuid(), Name = "Helms", Category = Categories.FirstOrDefault(x => x.Name == "Armor"), Discipline = disciplines.FirstOrDefault(x => x.Name == "Blacksmithing") });
            itemTypes.Add(new ItemTypes() { Id = Guid.NewGuid(), Name = "Sabatons", Category = Categories.FirstOrDefault(x => x.Name == "Armor"), Discipline = disciplines.FirstOrDefault(x => x.Name == "Blacksmithing") });
            itemTypes.Add(new ItemTypes() { Id = Guid.NewGuid(), Name = "Gauntlets", Category = Categories.FirstOrDefault(x => x.Name == "Armor"), Discipline = disciplines.FirstOrDefault(x => x.Name == "Blacksmithing") });
            itemTypes.Add(new ItemTypes() { Id = Guid.NewGuid(), Name = "Girdels", Category = Categories.FirstOrDefault(x => x.Name == "Armor"), Discipline = disciplines.FirstOrDefault(x => x.Name == "Blacksmithing") });

            itemTypes.Add(new ItemTypes() { Id = Guid.NewGuid(), Name = "Robes", Category = Categories.FirstOrDefault(x => x.Name == "Armor"), Discipline = disciplines.FirstOrDefault(x => x.Name == "Light Armor") });
            itemTypes.Add(new ItemTypes() { Id = Guid.NewGuid(), Name = "Sash", Category = Categories.FirstOrDefault(x => x.Name == "Armor"), Discipline = disciplines.FirstOrDefault(x => x.Name == "Light Armor") });
            itemTypes.Add(new ItemTypes() { Id = Guid.NewGuid(), Name = "Jerkin", Category = Categories.FirstOrDefault(x => x.Name == "Armor"), Discipline = disciplines.FirstOrDefault(x => x.Name == "Light Armor") });
            itemTypes.Add(new ItemTypes() { Id = Guid.NewGuid(), Name = "Hat", Category = Categories.FirstOrDefault(x => x.Name == "Armor"), Discipline = disciplines.FirstOrDefault(x => x.Name == "Light Armor") });
            itemTypes.Add(new ItemTypes() { Id = Guid.NewGuid(), Name = "Gloves", Category = Categories.FirstOrDefault(x => x.Name == "Armor"), Discipline = disciplines.FirstOrDefault(x => x.Name == "Light Armor") });
            itemTypes.Add(new ItemTypes() { Id = Guid.NewGuid(), Name = "Breeches", Category = Categories.FirstOrDefault(x => x.Name == "Armor"), Discipline = disciplines.FirstOrDefault(x => x.Name == "Light Armor") });
            itemTypes.Add(new ItemTypes() { Id = Guid.NewGuid(), Name = "Shoes", Category = Categories.FirstOrDefault(x => x.Name == "Armor"), Discipline = disciplines.FirstOrDefault(x => x.Name == "Light Armor") });
            itemTypes.Add(new ItemTypes() { Id = Guid.NewGuid(), Name = "Epaulets", Category = Categories.FirstOrDefault(x => x.Name == "Armor"), Discipline = disciplines.FirstOrDefault(x => x.Name == "Light Armor") });

            itemTypes.Add(new ItemTypes() { Id = Guid.NewGuid(), Name = "Jacks", Category = Categories.FirstOrDefault(x => x.Name == "Armor"), Discipline = disciplines.FirstOrDefault(x => x.Name == "Medium Armor") });
            itemTypes.Add(new ItemTypes() { Id = Guid.NewGuid(), Name = "Gaurds", Category = Categories.FirstOrDefault(x => x.Name == "Armor"), Discipline = disciplines.FirstOrDefault(x => x.Name == "Medium Armor") });
            itemTypes.Add(new ItemTypes() { Id = Guid.NewGuid(), Name = "Helmets", Category = Categories.FirstOrDefault(x => x.Name == "Armor"), Discipline = disciplines.FirstOrDefault(x => x.Name == "Medium Armor") });
            itemTypes.Add(new ItemTypes() { Id = Guid.NewGuid(), Name = "Arm Cops", Category = Categories.FirstOrDefault(x => x.Name == "Armor"), Discipline = disciplines.FirstOrDefault(x => x.Name == "Medium Armor") });
            itemTypes.Add(new ItemTypes() { Id = Guid.NewGuid(), Name = "Boots", Category = Categories.FirstOrDefault(x => x.Name == "Armor"), Discipline = disciplines.FirstOrDefault(x => x.Name == "Medium Armor") });
            itemTypes.Add(new ItemTypes() { Id = Guid.NewGuid(), Name = "Bracers", Category = Categories.FirstOrDefault(x => x.Name == "Armor"), Discipline = disciplines.FirstOrDefault(x => x.Name == "Medium Armor") });
            itemTypes.Add(new ItemTypes() { Id = Guid.NewGuid(), Name = "Belts", Category = Categories.FirstOrDefault(x => x.Name == "Armor"), Discipline = disciplines.FirstOrDefault(x => x.Name == "Medium Armor") });
            itemTypes.Add(new ItemTypes() { Id = Guid.NewGuid(), Name = "Epaulets", Category = Categories.FirstOrDefault(x => x.Name == "Armor"), Discipline = disciplines.FirstOrDefault(x => x.Name == "Medium Armor") });


            return itemTypes;
        }

        public List<CraftingDisciplines> CreateCraftingDisciplines()
        {
            List<CraftingDisciplines> craftingDisciplines = new List<CraftingDisciplines>();

            craftingDisciplines.Add(new CraftingDisciplines() { Id = Guid.NewGuid(), Name = "Blacksmithing" });
            craftingDisciplines.Add(new CraftingDisciplines() { Id = Guid.NewGuid(), Name = "Light Armor" });
            craftingDisciplines.Add(new CraftingDisciplines() { Id = Guid.NewGuid(), Name = "Medium Armor" });
            craftingDisciplines.Add(new CraftingDisciplines() { Id = Guid.NewGuid(), Name = "Woodworking" });

            return craftingDisciplines;
        }

        public List<CraftingMats> CreateCraftingMats(List<CraftingDisciplines> disciplines)
        {
            List<CraftingMats> mats = new List<CraftingMats>();
            var blackSmithing = disciplines.FirstOrDefault(x => x.Name == "Blacksmithing");
            mats.Add(new CraftingMats() { Id = Guid.NewGuid(), Name = "Iron", Discipline = blackSmithing, LevelRange = "1, 4, 6, 8, 10, 12, 14" ,IsCPItem = false});
            mats.Add(new CraftingMats() { Id = Guid.NewGuid(), Name = "Steel", Discipline = blackSmithing, LevelRange = "16, 18, 20, 22, 24", IsCPItem = false });
            mats.Add(new CraftingMats() { Id = Guid.NewGuid(), Name = "Orichalc", Discipline = blackSmithing, LevelRange = "26, 28, 30, 32, 34", IsCPItem = false });
            mats.Add(new CraftingMats() { Id = Guid.NewGuid(), Name = "Dwarven", Discipline = blackSmithing, LevelRange = "36, 38, 40, 42, 44", IsCPItem = false });
            mats.Add(new CraftingMats() { Id = Guid.NewGuid(), Name = "Ebon", Discipline = blackSmithing, LevelRange = "46, 48, 50", IsCPItem = false });
            mats.Add(new CraftingMats() { Id = Guid.NewGuid(), Name = "Calcinium", Discipline = blackSmithing, LevelRange = "10, 20, 30", IsCPItem = true });
            mats.Add(new CraftingMats() { Id = Guid.NewGuid(), Name = "Galatite", Discipline = blackSmithing, LevelRange = "40, 50, 60", IsCPItem = true });
            mats.Add(new CraftingMats() { Id = Guid.NewGuid(), Name = "Quicksilver", Discipline = blackSmithing, LevelRange = "70, 80", IsCPItem = true });
            mats.Add(new CraftingMats() { Id = Guid.NewGuid(), Name = "Voidsteel", Discipline = blackSmithing, LevelRange = "90, 100, 110, 120, 130, 140", IsCPItem = true });
            mats.Add(new CraftingMats() { Id = Guid.NewGuid(), Name = "Rubedite", Discipline = blackSmithing, LevelRange = "150, 160", IsCPItem = true });

            var lightArmor = disciplines.FirstOrDefault(x => x.Name == "Light Armor");
            mats.Add(new CraftingMats() { Id = Guid.NewGuid(), Name = "Homespun", Discipline = lightArmor, LevelRange = "1, 4, 6, 8, 10, 12, 14", IsCPItem = false });
            mats.Add(new CraftingMats() { Id = Guid.NewGuid(), Name = "Linen", Discipline = lightArmor, LevelRange = "16, 18, 20, 22, 24", IsCPItem = false });
            mats.Add(new CraftingMats() { Id = Guid.NewGuid(), Name = "Cotton", Discipline = lightArmor, LevelRange = "26, 28, 30, 32, 34", IsCPItem = false });
            mats.Add(new CraftingMats() { Id = Guid.NewGuid(), Name = "Spidersilk", Discipline = lightArmor, LevelRange = "36, 38, 40, 42, 44", IsCPItem = false });
            mats.Add(new CraftingMats() { Id = Guid.NewGuid(), Name = "Ebonthread", Discipline = lightArmor, LevelRange = "46, 48, 50", IsCPItem = false });
            mats.Add(new CraftingMats() { Id = Guid.NewGuid(), Name = "Kresh", Discipline = lightArmor, LevelRange = "10, 20, 30", IsCPItem = true });
            mats.Add(new CraftingMats() { Id = Guid.NewGuid(), Name = "Ironthread", Discipline = lightArmor, LevelRange = "40, 50, 60", IsCPItem = true });
            mats.Add(new CraftingMats() { Id = Guid.NewGuid(), Name = "Silverweave", Discipline = lightArmor, LevelRange = "70, 80", IsCPItem = true });
            mats.Add(new CraftingMats() { Id = Guid.NewGuid(), Name = "Shadowspun", Discipline = lightArmor, LevelRange = "90, 100, 110, 120, 130, 140", IsCPItem = true });
            mats.Add(new CraftingMats() { Id = Guid.NewGuid(), Name = "Ancient Silk", Discipline = lightArmor, LevelRange = "150, 160", IsCPItem = true });

            var mediumArmor = disciplines.FirstOrDefault(x => x.Name == "Medium Armor");
            mats.Add(new CraftingMats() { Id = Guid.NewGuid(), Name = "Rawhide", Discipline = mediumArmor, LevelRange = "1, 4, 6, 8, 10, 12, 14", IsCPItem = false });
            mats.Add(new CraftingMats() { Id = Guid.NewGuid(), Name = "Hide", Discipline = mediumArmor, LevelRange = "16, 18, 20, 22, 24", IsCPItem = false });
            mats.Add(new CraftingMats() { Id = Guid.NewGuid(), Name = "Leather", Discipline = mediumArmor, LevelRange = "26, 28, 30, 32, 34", IsCPItem = false });
            mats.Add(new CraftingMats() { Id = Guid.NewGuid(), Name = "Full-Leather", Discipline = mediumArmor, LevelRange = "36, 38, 40, 42, 44", IsCPItem = false });
            mats.Add(new CraftingMats() { Id = Guid.NewGuid(), Name = "Fell", Discipline = mediumArmor, LevelRange = "46, 48, 50", IsCPItem = false });
            mats.Add(new CraftingMats() { Id = Guid.NewGuid(), Name = "Brigadine", Discipline = mediumArmor, LevelRange = "10, 20, 30", IsCPItem = true });
            mats.Add(new CraftingMats() { Id = Guid.NewGuid(), Name = "Ironhide", Discipline = mediumArmor, LevelRange = "40, 50, 60", IsCPItem = true });
            mats.Add(new CraftingMats() { Id = Guid.NewGuid(), Name = "Superb", Discipline = mediumArmor, LevelRange = "70, 80", IsCPItem = true });
            mats.Add(new CraftingMats() { Id = Guid.NewGuid(), Name = "Shadowhide", Discipline = mediumArmor, LevelRange = "90, 100, 110, 120, 130, 140", IsCPItem = true });
            mats.Add(new CraftingMats() { Id = Guid.NewGuid(), Name = "Rubedo Leather", Discipline = mediumArmor, LevelRange = "150, 160", IsCPItem = true });

            return mats;
        }

        public List<ItemCategory> CreateItemCategories()
        {
            List<ItemCategory> itemTypes = new List<ItemCategory>();

            itemTypes.Add(new ItemCategory() { Id = Guid.NewGuid(), Name = "Armor" });
            itemTypes.Add(new ItemCategory() { Id = Guid.NewGuid(), Name = "Weapon" });
            itemTypes.Add(new ItemCategory() { Id = Guid.NewGuid(), Name = "Jewellery" });
            itemTypes.Add(new ItemCategory() { Id = Guid.NewGuid(), Name = "Shields" });

            return itemTypes;
        }

        public List<ItemQuality> CreateQualities()
        {

            List<ItemQuality> qualities = new List<ItemQuality>();

            qualities.Add(new ItemQuality() { Id = Guid.NewGuid(), Name = "Normal" });
            qualities.Add(new ItemQuality() { Id = Guid.NewGuid(), Name = "Fine" });
            qualities.Add(new ItemQuality() { Id = Guid.NewGuid(), Name = "Superior" });
            qualities.Add(new ItemQuality() { Id = Guid.NewGuid(), Name = "Epic" });
            qualities.Add(new ItemQuality() { Id = Guid.NewGuid(), Name = "Legendary" });

            return qualities;

        }

        private List<Item> CreateWeapons(List<ItemNames> Names,List<ItemCategory> ItemTypes,List<ItemQuality> qualities)
        {
            List<Item> items = new List<Item>();

            items.AddRange(CreateItems( Names, qualities));

            return items;
        }

        
        public List<ItemNames> CreateItemNames(List<ItemTypes> itemTypes,List<CraftingMats> mats)
        {
            List<ItemNames> names = new List<ItemNames>();

            foreach (var mat in mats)
            {
                
                foreach (var type in itemTypes.Where(x => x.Discipline == mat.Discipline))
                {
                    
                    names.Add(new ItemNames() { Id = Guid.NewGuid(), Mat = mat, Name = mat.Name + " " + type.Name,TypeOfItem = type });
                }
                
            }
            
            return names;
        } 


        public List<Item> CreateItems(List<ItemNames> Name, List<ItemQuality> Qualities)
        {
            List<Item> items = new List<Item>();

            foreach (var itemName in Name)
            {
                var itemLevels = itemName.Mat.LevelRange.Split(',');
                foreach (var level in itemLevels)
                {
                    int levelnum = int.Parse(level);

                    foreach (var quality in Qualities)
                    {
                        items.Add(new Item() { Id = Guid.NewGuid(), Name = itemName, Quality = quality, ItemLevel = levelnum });
                    }
                }

            }

            return items;
        }
    }
}
