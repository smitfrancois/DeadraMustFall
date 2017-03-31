using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeadraMustFall.Model.Domains;

namespace DeadraMustFall.Model
{
    public class DeadraMustFallInitializer:DropCreateDatabaseIfModelChanges<DeadraMustFallContext>
    {
   
        protected override void Seed(DeadraMustFallContext context)
        {
            //Create Items
            var craftingDisciplines = CreateCraftingDisciplines();
            var craftingMats = CreateCraftingMats(craftingDisciplines);
            var itemCategory = CreateItemCategories();
            var itemTypes = CreateItemTypes(itemCategory, craftingDisciplines);
            var qualities = CreateQualities();
            var names = CreateItemNames(itemTypes,craftingMats);
            var items = CreateWeapons(names, itemCategory, qualities);
            

            //Create Races
            var races = CreateRaces();
            var classes = CreateClasses();

            //Skills
            var skillLineCategories = CreateSkillLineCategories();
            var skillLines = CreateSkillLines(skillLineCategories);
            var skillTypes = CreateSkillTypes();
            var skills = CreateSkills(skillLines, skillTypes);

            context.SkillTypes.AddRange(skillTypes);
            context.Skills.AddRange(skills);
            context.SkillLines.AddRange(skillLines);
            context.Classes.AddRange(classes);
            context.Races.AddRange(races);
            context.ItemTypes.AddRange(itemTypes);
            context.CraftingDisciplines.AddRange(craftingDisciplines);
            context.CraftingMaterials.AddRange(craftingMats);
            context.ItemQualities.AddRange(qualities);
            context.ItemCategories.AddRange(itemCategory);
            context.ItemNames.AddRange(names);
            context.Items.AddRange(items);
           
           

            base.Seed(context);
        }

        public List<SkillType> CreateSkillTypes()
        {
            List<SkillType> skillTypes = new List<SkillType>();

            skillTypes.Add(new SkillType() {Id= Guid.NewGuid(),Name="Active" });
            skillTypes.Add(new SkillType() { Id = Guid.NewGuid(), Name = "Passive" });
            skillTypes.Add(new SkillType() { Id = Guid.NewGuid(), Name = "Morph" });
            skillTypes.Add(new SkillType() { Id = Guid.NewGuid(), Name = "Ultimate" });

            return skillTypes;
        }

        public List<Skill> CreateSkills(List<SkillLines> skillLines,List<SkillType> skillTypes)
        {
            List<Skill> skills = new List<Skill>();

            var skillLine = skillLines.FirstOrDefault(x => x.Name == "Aedric Spear");
            var skillType = skillTypes.FirstOrDefault(x => x.Name == "Ultimate");
            //Radial Sweep
            var parentSkill = new Skill() { Id = Guid.NewGuid(), Name = "Radial Sweep", Description = "<ul><li>Swing your Aedric spear around with holy vengeance, dealing [x] Magic Damage to all nearby enemies and additional [y] Magic Damage every 2 seconds for 6 seconds.</li></ul>", SkillLine = skillLine, SkillType = skillType, Unlocks = "Rank 12 " + skillLine.Name, CastTime = "Instant", Cost = "75" + skillType.Name, RadiusRange = "6m Radius", IsMorph = false };
            skills.Add(parentSkill);
            skills.Add(new Skill() { Id = Guid.NewGuid(), Name = "Empowering Sweep", Description = "<ul><li>Also reduces damage deal to you by 15 % for 10 seconds, plus an additional 4 % for each enemy hit. </li><li> Take reduced damage for each enemy hit.</li></ul>", SkillLine = skillLine, SkillType = skillType, Unlocks = parentSkill.Name + " Rank IV", CastTime = "Instant", Cost = "75 " + skillType.Name, RadiusRange = "6m Radius",IsMorph=true,ParentSkill=parentSkill });
            skills.Add(new Skill() { Id = Guid.NewGuid(), Name = "Crescent Sweep", Description = "<ul><li>Enemies in front of you take 66 % more initial damage.</li><li>Deals Physical Damage and also deals addtional damage to enemies in front of you</li></ul>", SkillLine = skillLine, SkillType = skillType, Unlocks = parentSkill.Name + " Rank IV", CastTime = "Instant", Cost = "75 " + skillType.Name, RadiusRange = "6m Radius", IsMorph = true, ParentSkill = parentSkill });

            //Puncturing Strikes
            skillType = skillTypes.FirstOrDefault(x => x.Name == "Active");
            parentSkill = new Skill() { Id = Guid.NewGuid(), Name = "Puncturing Strikes", Description = "<ul><li>Launch a relentless assault, striking enemies in front of you four times with your Aedric spear dealing Magic Damage with each strike.</li><li>The closest enemy takes 140 % additional damage each strike, and their Movement Speed is reduced by 70 % for 2 seconds on the final hit.</li><li>The damage from this ability and its morphs can no longer be dodged.</li></ul>", SkillLine = skillLine, SkillType = skillType, Unlocks = skillLine.Name + " 1", CastTime = "1.1s", Cost = "2952 Magicka", RadiusRange = "8m Range", IsMorph = false };
            skills.Add(parentSkill);
            skills.Add(new Skill() { Id = Guid.NewGuid(), Name = "Biting Jabs", Description = "<ul><li>Also grants you Major Savagery, increasing your Weapon Critical rating by 2191 for 8 seconds.</li><li>The damage from this ability and its morphs can no longer be dodged.</li><li>Converts to a Stamina ability, and increases your Weapon Critical rating when used.</li></ul>", SkillLine = skillLine, SkillType = skillType, Unlocks = parentSkill.Name + " Rank IV", CastTime = "1.1s", Cost = "2903 Stamina", RadiusRange = "8m Range", IsMorph = true, ParentSkill = parentSkill });
            skills.Add(new Skill() { Id = Guid.NewGuid(), Name = "Puncturing Sweep", Description = "<lu><li>Heals you for 35% of damage done.</li><li>The damage from this ability and its morphs can no longer be dodged.</li><li>Also heals you for a percentage of the damage done.</li></ul>", SkillLine = skillLine, SkillType = skillType, Unlocks = parentSkill.Name + " Rank IV", CastTime = "1.1s", Cost = "2952 Magicka", RadiusRange = "8m Range", IsMorph = true, ParentSkill = parentSkill });

            //Piercing Javelin
            parentSkill = new Skill() { Id = Guid.NewGuid(), Name = "Piercing Javelin", Description = "<lu><li>Hurl your spear at an enemy with godlike strength, dealing [x] Magic Damage, stunning them for 1.8 seconds, and knocking them back 5 meters.</li></ul>", SkillLine = skillLine, SkillType = skillType, Unlocks = skillLine.Name + " 4", CastTime = "Instant", Cost = "4050 Magicka", RadiusRange = "28m Range", IsMorph = false };
            skills.Add(parentSkill);
            skills.Add(new Skill() { Id = Guid.NewGuid(), Name = "Aurora Javelin", Description = "<ul><li>Deals up to 40% more damage based on the distance the spear travels.</li><li>Deals additional damage based on the distance the spear travels.</li></ul>", SkillLine = skillLine, SkillType = skillType, Unlocks = parentSkill.Name + " Rank IV", CastTime = "Instant", Cost = "4050 Magicka", RadiusRange = "28m Range", IsMorph = true, ParentSkill = parentSkill });
            skills.Add(new Skill() { Id = Guid.NewGuid(), Name = "Puncturing Sweep", Description = "<ul><li>Hurl your spear at an enemy with godlike strength, dealing [x] Physical Damage, stunning them for 3 seconds, and knocking them back 5 meters.</li><li>Converts to a Stamina ability, and stuns the enemy for a longer duration.</li></ul>", SkillLine = skillLine, SkillType = skillType, Unlocks = parentSkill.Name + " Rank IV", CastTime = "Instant", Cost = "3983 Stamina", RadiusRange = "28m Range", IsMorph = true, ParentSkill = parentSkill });

            //Piercing Javelin
            parentSkill = new Skill() { Id = Guid.NewGuid(), Name = "Focused Charge", Description = "<lu><li>Hurl your spear at an enemy with godlike strength, dealing [x] Magic Damage, stunning them for 1.8 seconds, and knocking them back 5 meters.</li></ul>", SkillLine = skillLine, SkillType = skillType, Unlocks = skillLine.Name + " 4", CastTime = "Instant", Cost = "4050 Magicka", RadiusRange = "28m Range", IsMorph = false };
            skills.Add(parentSkill);
            skills.Add(new Skill() { Id = Guid.NewGuid(), Name = "Explosive Charge", Description = "<ul><li>Deals up to 40% more damage based on the distance the spear travels.</li><li>Deals additional damage based on the distance the spear travels.</li></ul>", SkillLine = skillLine, SkillType = skillType, Unlocks = parentSkill.Name + " Rank IV", CastTime = "Instant", Cost = "4050 Magicka", RadiusRange = "28m Range", IsMorph = true, ParentSkill = parentSkill });
            skills.Add(new Skill() { Id = Guid.NewGuid(), Name = "Toppling Charge", Description = "<ul><li>Hurl your spear at an enemy with godlike strength, dealing [x] Physical Damage, stunning them for 3 seconds, and knocking them back 5 meters.</li><li>Converts to a Stamina ability, and stuns the enemy for a longer duration.</li></ul>", SkillLine = skillLine, SkillType = skillType, Unlocks = parentSkill.Name + " Rank IV", CastTime = "Instant", Cost = "3983 Stamina", RadiusRange = "28m Range", IsMorph = true, ParentSkill = parentSkill });

            return skills;
        }

        

        public List<SkillLineCategories> CreateSkillLineCategories()
        {
            List<SkillLineCategories> categories = new List<SkillLineCategories>();

            categories.Add(new SkillLineCategories() { Id = Guid.NewGuid(),Name="Class"});
            categories.Add(new SkillLineCategories() { Id = Guid.NewGuid(), Name = "Weapon" });
            categories.Add(new SkillLineCategories() { Id = Guid.NewGuid(), Name = "Armor" });
            categories.Add(new SkillLineCategories() { Id = Guid.NewGuid(), Name = "Guild" });
            categories.Add(new SkillLineCategories() { Id = Guid.NewGuid(), Name = "World" });
            categories.Add(new SkillLineCategories() { Id = Guid.NewGuid(), Name = "Alliance War" });
            categories.Add(new SkillLineCategories() { Id = Guid.NewGuid(), Name = "Racial" });
            categories.Add(new SkillLineCategories() { Id = Guid.NewGuid(), Name = "Craft" });

            return categories;
        }

        public List<SkillLines> CreateSkillLines(List<SkillLineCategories> skillCategories)
        {
            List<SkillLines> skillLines = new List<SkillLines>();

            //Class Skill Lines
            skillLines.Add(new SkillLines() { Id = Guid.NewGuid(), Name = "Aedric Spear" ,SkillCategory = skillCategories.FirstOrDefault(x => x.Name == "Class")});
            skillLines.Add(new SkillLines() { Id = Guid.NewGuid(), Name = "Dawn's Wrath", SkillCategory = skillCategories.FirstOrDefault(x => x.Name == "Class") });
            skillLines.Add(new SkillLines() { Id = Guid.NewGuid(), Name = "Restoring Light", SkillCategory = skillCategories.FirstOrDefault(x => x.Name == "Class") });
            skillLines.Add(new SkillLines() { Id = Guid.NewGuid(), Name = "Ardent Flame", SkillCategory = skillCategories.FirstOrDefault(x => x.Name == "Class") });
            skillLines.Add(new SkillLines() { Id = Guid.NewGuid(), Name = "Draconic Power", SkillCategory = skillCategories.FirstOrDefault(x => x.Name == "Class") });
            skillLines.Add(new SkillLines() { Id = Guid.NewGuid(), Name = "Earthen Heart", SkillCategory = skillCategories.FirstOrDefault(x => x.Name == "Class") });
            skillLines.Add(new SkillLines() { Id = Guid.NewGuid(), Name = "Dark Magic", SkillCategory = skillCategories.FirstOrDefault(x => x.Name == "Class") });
            skillLines.Add(new SkillLines() { Id = Guid.NewGuid(), Name = "Deadric Summoning", SkillCategory = skillCategories.FirstOrDefault(x => x.Name == "Class") });
            skillLines.Add(new SkillLines() { Id = Guid.NewGuid(), Name = "Storm Calling", SkillCategory = skillCategories.FirstOrDefault(x => x.Name == "Class") });
            skillLines.Add(new SkillLines() { Id = Guid.NewGuid(), Name = "Assasination", SkillCategory = skillCategories.FirstOrDefault(x => x.Name == "Class") });
            skillLines.Add(new SkillLines() { Id = Guid.NewGuid(), Name = "Shadow", SkillCategory = skillCategories.FirstOrDefault(x => x.Name == "Class") });
            skillLines.Add(new SkillLines() { Id = Guid.NewGuid(), Name = "Siphoning", SkillCategory = skillCategories.FirstOrDefault(x => x.Name == "Class") });

            //Weapon Skills
            skillLines.Add(new SkillLines() { Id = Guid.NewGuid(), Name = "Two-Handed", SkillCategory = skillCategories.FirstOrDefault(x => x.Name == "Weapon") });
            skillLines.Add(new SkillLines() { Id = Guid.NewGuid(), Name = "One Handed and Shield", SkillCategory = skillCategories.FirstOrDefault(x => x.Name == "Weapon") });
            skillLines.Add(new SkillLines() { Id = Guid.NewGuid(), Name = "Dual Wield", SkillCategory = skillCategories.FirstOrDefault(x => x.Name == "Weapon") });
            skillLines.Add(new SkillLines() { Id = Guid.NewGuid(), Name = "Bow", SkillCategory = skillCategories.FirstOrDefault(x => x.Name == "Weapon") });
            skillLines.Add(new SkillLines() { Id = Guid.NewGuid(), Name = "Destruction Staff", SkillCategory = skillCategories.FirstOrDefault(x => x.Name == "Weapon") });
            skillLines.Add(new SkillLines() { Id = Guid.NewGuid(), Name = "Restoration Staff", SkillCategory = skillCategories.FirstOrDefault(x => x.Name == "Weapon") });

            //Armor Skills
            skillLines.Add(new SkillLines() { Id = Guid.NewGuid(), Name = "Heavy Armor", SkillCategory = skillCategories.FirstOrDefault(x => x.Name == "Armor") });
            skillLines.Add(new SkillLines() { Id = Guid.NewGuid(), Name = "Medium Armor", SkillCategory = skillCategories.FirstOrDefault(x => x.Name == "Armor") });
            skillLines.Add(new SkillLines() { Id = Guid.NewGuid(), Name = "Light Armor", SkillCategory = skillCategories.FirstOrDefault(x => x.Name == "Armor") });

            //Guild Skills
            skillLines.Add(new SkillLines() { Id = Guid.NewGuid(), Name = "Fighters Guild", SkillCategory = skillCategories.FirstOrDefault(x => x.Name == "Guild") });
            skillLines.Add(new SkillLines() { Id = Guid.NewGuid(), Name = "Mages Guild", SkillCategory = skillCategories.FirstOrDefault(x => x.Name == "Guild") });
            skillLines.Add(new SkillLines() { Id = Guid.NewGuid(), Name = "Thieves Guild", SkillCategory = skillCategories.FirstOrDefault(x => x.Name == "Guild") });
            skillLines.Add(new SkillLines() { Id = Guid.NewGuid(), Name = "Dark Brotherhood", SkillCategory = skillCategories.FirstOrDefault(x => x.Name == "Guild") });
            skillLines.Add(new SkillLines() { Id = Guid.NewGuid(), Name = "Undaunted", SkillCategory = skillCategories.FirstOrDefault(x => x.Name == "Guild") });

            //World Skills
            skillLines.Add(new SkillLines() { Id = Guid.NewGuid(), Name = "Vampire", SkillCategory = skillCategories.FirstOrDefault(x => x.Name == "World") });
            skillLines.Add(new SkillLines() { Id = Guid.NewGuid(), Name = "Warewolf", SkillCategory = skillCategories.FirstOrDefault(x => x.Name == "World") });
            skillLines.Add(new SkillLines() { Id = Guid.NewGuid(), Name = "Legerdemain", SkillCategory = skillCategories.FirstOrDefault(x => x.Name == "World") });
            skillLines.Add(new SkillLines() { Id = Guid.NewGuid(), Name = "Soul Magic", SkillCategory = skillCategories.FirstOrDefault(x => x.Name == "World") });

            //Alliance War Skills
            skillLines.Add(new SkillLines() { Id = Guid.NewGuid(), Name = "Assault", SkillCategory = skillCategories.FirstOrDefault(x => x.Name == "Alliance War") });
            skillLines.Add(new SkillLines() { Id = Guid.NewGuid(), Name = "Support", SkillCategory = skillCategories.FirstOrDefault(x => x.Name == "Alliance War") });
            skillLines.Add(new SkillLines() { Id = Guid.NewGuid(), Name = "Emperor", SkillCategory = skillCategories.FirstOrDefault(x => x.Name == "Alliance War") });

            //Racial Skills
            skillLines.Add(new SkillLines() { Id = Guid.NewGuid(), Name = "Breton", SkillCategory = skillCategories.FirstOrDefault(x => x.Name == "Racial") });
            skillLines.Add(new SkillLines() { Id = Guid.NewGuid(), Name = "Argonian", SkillCategory = skillCategories.FirstOrDefault(x => x.Name == "Racial") });
            skillLines.Add(new SkillLines() { Id = Guid.NewGuid(), Name = "Red Gaurd", SkillCategory = skillCategories.FirstOrDefault(x => x.Name == "Racial") });
            skillLines.Add(new SkillLines() { Id = Guid.NewGuid(), Name = "Imperial", SkillCategory = skillCategories.FirstOrDefault(x => x.Name == "Racial") });
            skillLines.Add(new SkillLines() { Id = Guid.NewGuid(), Name = "Khajiit", SkillCategory = skillCategories.FirstOrDefault(x => x.Name == "Racial") });
            skillLines.Add(new SkillLines() { Id = Guid.NewGuid(), Name = "Dunmer", SkillCategory = skillCategories.FirstOrDefault(x => x.Name == "Racial") });
            skillLines.Add(new SkillLines() { Id = Guid.NewGuid(), Name = "Altmer", SkillCategory = skillCategories.FirstOrDefault(x => x.Name == "Racial") });
            skillLines.Add(new SkillLines() { Id = Guid.NewGuid(), Name = "Bosmer", SkillCategory = skillCategories.FirstOrDefault(x => x.Name == "Racial") });
            skillLines.Add(new SkillLines() { Id = Guid.NewGuid(), Name = "Nord", SkillCategory = skillCategories.FirstOrDefault(x => x.Name == "Racial") });
            skillLines.Add(new SkillLines() { Id = Guid.NewGuid(), Name = "Orc", SkillCategory = skillCategories.FirstOrDefault(x => x.Name == "Racial") });

            //Craft Skills
            skillLines.Add(new SkillLines() { Id = Guid.NewGuid(), Name = "Alchemy", SkillCategory = skillCategories.FirstOrDefault(x => x.Name == "Craft") });
            skillLines.Add(new SkillLines() { Id = Guid.NewGuid(), Name = "Blacksmithing", SkillCategory = skillCategories.FirstOrDefault(x => x.Name == "Craft") });
            skillLines.Add(new SkillLines() { Id = Guid.NewGuid(), Name = "Woodworking", SkillCategory = skillCategories.FirstOrDefault(x => x.Name == "Craft") });
            skillLines.Add(new SkillLines() { Id = Guid.NewGuid(), Name = "Enchanting", SkillCategory = skillCategories.FirstOrDefault(x => x.Name == "Craft") });
            skillLines.Add(new SkillLines() { Id = Guid.NewGuid(), Name = "Provisioning", SkillCategory = skillCategories.FirstOrDefault(x => x.Name == "Craft") });
            skillLines.Add(new SkillLines() { Id = Guid.NewGuid(), Name = "Clothing", SkillCategory = skillCategories.FirstOrDefault(x => x.Name == "Craft") });

            return skillLines;
        }

        public List<Race> CreateRaces()
        {
            List<Race> races = new List<Race>();

            races.Add(new Race() { Id=Guid.NewGuid(), Name = "Breton" });
            races.Add(new Race() { Id = Guid.NewGuid(), Name = "Argonian" });
            races.Add(new Race() { Id = Guid.NewGuid(), Name = "Red Gaurd" });
            races.Add(new Race() { Id = Guid.NewGuid(), Name = "Khajiit" });
            races.Add(new Race() { Id = Guid.NewGuid(), Name = "Nord" });
            races.Add(new Race() { Id = Guid.NewGuid(), Name = "Bosmer" });
            races.Add(new Race() { Id = Guid.NewGuid(), Name = "Orc" });
            races.Add(new Race() { Id = Guid.NewGuid(), Name = "Dunmer" });
            races.Add(new Race() { Id = Guid.NewGuid(), Name = "Altmer" });
            races.Add(new Race() { Id = Guid.NewGuid(), Name = "Imperial" });

            return races;
        }

        public List<Class> CreateClasses()
        {
            List<Class> classes = new List<Class>();

            classes.Add(new Class() {Id = Guid.NewGuid(),Name="Templar" });
            classes.Add(new Class() { Id = Guid.NewGuid(), Name = "Nightblade" });
            classes.Add(new Class() { Id = Guid.NewGuid(), Name = "Sorcerer" });
            classes.Add(new Class() { Id = Guid.NewGuid(), Name = "Dragon Knight" });

            return classes;
        }
 
        #region Create Items
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

            itemTypes.Add(new ItemTypes() { Id = Guid.NewGuid(), Name = "Bow", Category = Categories.FirstOrDefault(x => x.Name == "Weapon"), Discipline = disciplines.FirstOrDefault(x => x.Name == "Woodworking") });
            itemTypes.Add(new ItemTypes() { Id = Guid.NewGuid(), Name = "Inferno Staff", Category = Categories.FirstOrDefault(x => x.Name == "Weapon"), Discipline = disciplines.FirstOrDefault(x => x.Name == "Woodworking") });
            itemTypes.Add(new ItemTypes() { Id = Guid.NewGuid(), Name = "Ice Staff", Category = Categories.FirstOrDefault(x => x.Name == "Weapon"), Discipline = disciplines.FirstOrDefault(x => x.Name == "Woodworking") });
            itemTypes.Add(new ItemTypes() { Id = Guid.NewGuid(), Name = "Lightning Staff", Category = Categories.FirstOrDefault(x => x.Name == "Weapon"), Discipline = disciplines.FirstOrDefault(x => x.Name == "Woodworking") });
            itemTypes.Add(new ItemTypes() { Id = Guid.NewGuid(), Name = "Restoration Staff", Category = Categories.FirstOrDefault(x => x.Name == "Weapon"), Discipline = disciplines.FirstOrDefault(x => x.Name == "Woodworking") });
            itemTypes.Add(new ItemTypes() { Id = Guid.NewGuid(), Name = "Shield", Category = Categories.FirstOrDefault(x => x.Name == "Shields"), Discipline = disciplines.FirstOrDefault(x => x.Name == "Woodworking") });


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

            var woodWorking = disciplines.FirstOrDefault(x => x.Name == "Woodworking");
            mats.Add(new CraftingMats() { Id = Guid.NewGuid(), Name = "Maple", Discipline = woodWorking, LevelRange = "1, 4, 6, 8, 10, 12, 14", IsCPItem = false });
            mats.Add(new CraftingMats() { Id = Guid.NewGuid(), Name = "Oak", Discipline = woodWorking, LevelRange = "16, 18, 20, 22, 24", IsCPItem = false });
            mats.Add(new CraftingMats() { Id = Guid.NewGuid(), Name = "Beech", Discipline = woodWorking, LevelRange = "26, 28, 30, 32, 34", IsCPItem = false });
            mats.Add(new CraftingMats() { Id = Guid.NewGuid(), Name = "Hickory", Discipline = woodWorking, LevelRange = "36, 38, 40, 42, 44", IsCPItem = false });
            mats.Add(new CraftingMats() { Id = Guid.NewGuid(), Name = "Yew", Discipline = woodWorking, LevelRange = "46, 48, 50", IsCPItem = false });
            mats.Add(new CraftingMats() { Id = Guid.NewGuid(), Name = "Birch", Discipline = woodWorking, LevelRange = "10, 20, 30", IsCPItem = true });
            mats.Add(new CraftingMats() { Id = Guid.NewGuid(), Name = "Ash", Discipline = woodWorking, LevelRange = "40, 50, 60", IsCPItem = true });
            mats.Add(new CraftingMats() { Id = Guid.NewGuid(), Name = "Mahogany", Discipline = woodWorking, LevelRange = "70, 80", IsCPItem = true });
            mats.Add(new CraftingMats() { Id = Guid.NewGuid(), Name = "Nightwood", Discipline = woodWorking, LevelRange = "90, 100, 110, 120, 130, 140", IsCPItem = true });
            mats.Add(new CraftingMats() { Id = Guid.NewGuid(), Name = "Ruby Ash", Discipline = woodWorking, LevelRange = "150, 160", IsCPItem = true });

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
                        items.Add(new Item() {  Id = Guid.NewGuid(), Name = itemName, Quality = quality, ItemLevel = levelnum });
                    }
                }

            }

            return items;
        }

        #endregion
    }
}
