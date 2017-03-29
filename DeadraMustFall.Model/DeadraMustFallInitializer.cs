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
            var items = CreateWeapons();

            foreach (var item in items)
            {
                context.Items.Add(item);
            }


            base.Seed(context);
        }

        private List<Item> CreateWeapons()
        {
            List<Item> items = new List<Item>();
            items.Add(new Item() { ItemType = ItemTypes.Weapon, Name = "Iron Axe", Quality = ItemQuality.Normal, ItemLevel = 1});
            items.Add(new Item() { ItemType = ItemTypes.Weapon, Name = "Iron Axe", Quality = ItemQuality.Normal, ItemLevel = 4 });
            items.Add(new Item() { ItemType = ItemTypes.Weapon, Name = "Iron Axe", Quality = ItemQuality.Normal, ItemLevel = 6 });
            items.Add(new Item() { ItemType = ItemTypes.Weapon, Name = "Iron Axe", Quality = ItemQuality.Normal, ItemLevel = 8 });
            items.Add(new Item() { ItemType = ItemTypes.Weapon, Name = "Iron Axe", Quality = ItemQuality.Normal, ItemLevel = 10 });
            items.Add(new Item() { ItemType = ItemTypes.Weapon, Name = "Iron Axe", Quality = ItemQuality.Normal, ItemLevel = 12 });
            items.Add(new Item() { ItemType = ItemTypes.Weapon, Name = "Iron Axe", Quality = ItemQuality.Normal, ItemLevel = 14 });

            items.Add(new Item() { ItemType = ItemTypes.Weapon, Name = "Iron Axe", Quality = ItemQuality.Fine, ItemLevel = 1 });
            items.Add(new Item() { ItemType = ItemTypes.Weapon, Name = "Iron Axe", Quality = ItemQuality.Fine, ItemLevel = 4 });
            items.Add(new Item() { ItemType = ItemTypes.Weapon, Name = "Iron Axe", Quality = ItemQuality.Fine, ItemLevel = 6 });
            items.Add(new Item() { ItemType = ItemTypes.Weapon, Name = "Iron Axe", Quality = ItemQuality.Fine, ItemLevel = 8 });
            items.Add(new Item() { ItemType = ItemTypes.Weapon, Name = "Iron Axe", Quality = ItemQuality.Fine, ItemLevel = 10 });
            items.Add(new Item() { ItemType = ItemTypes.Weapon, Name = "Iron Axe", Quality = ItemQuality.Fine, ItemLevel = 12 });
            items.Add(new Item() { ItemType = ItemTypes.Weapon, Name = "Iron Axe", Quality = ItemQuality.Fine, ItemLevel = 14 });

            items.Add(new Item() { ItemType = ItemTypes.Weapon, Name = "Iron Axe", Quality = ItemQuality.Superior, ItemLevel = 1 });
            items.Add(new Item() { ItemType = ItemTypes.Weapon, Name = "Iron Axe", Quality = ItemQuality.Superior, ItemLevel = 4 });
            items.Add(new Item() { ItemType = ItemTypes.Weapon, Name = "Iron Axe", Quality = ItemQuality.Superior, ItemLevel = 6 });
            items.Add(new Item() { ItemType = ItemTypes.Weapon, Name = "Iron Axe", Quality = ItemQuality.Superior, ItemLevel = 8 });
            items.Add(new Item() { ItemType = ItemTypes.Weapon, Name = "Iron Axe", Quality = ItemQuality.Superior, ItemLevel = 10 });
            items.Add(new Item() { ItemType = ItemTypes.Weapon, Name = "Iron Axe", Quality = ItemQuality.Superior, ItemLevel = 12 });
            items.Add(new Item() { ItemType = ItemTypes.Weapon, Name = "Iron Axe", Quality = ItemQuality.Superior, ItemLevel = 14 });

            items.Add(new Item() { ItemType = ItemTypes.Weapon, Name = "Iron Axe", Quality = ItemQuality.Epic, ItemLevel = 1 });
            items.Add(new Item() { ItemType = ItemTypes.Weapon, Name = "Iron Axe", Quality = ItemQuality.Epic, ItemLevel = 4 });
            items.Add(new Item() { ItemType = ItemTypes.Weapon, Name = "Iron Axe", Quality = ItemQuality.Epic, ItemLevel = 6 });
            items.Add(new Item() { ItemType = ItemTypes.Weapon, Name = "Iron Axe", Quality = ItemQuality.Epic, ItemLevel = 8 });
            items.Add(new Item() { ItemType = ItemTypes.Weapon, Name = "Iron Axe", Quality = ItemQuality.Epic, ItemLevel = 10 });
            items.Add(new Item() { ItemType = ItemTypes.Weapon, Name = "Iron Axe", Quality = ItemQuality.Epic, ItemLevel = 12 });
            items.Add(new Item() { ItemType = ItemTypes.Weapon, Name = "Iron Axe", Quality = ItemQuality.Epic, ItemLevel = 14 });

            items.Add(new Item() { ItemType = ItemTypes.Weapon, Name = "Iron Axe", Quality = ItemQuality.Legendary, ItemLevel = 1 });
            items.Add(new Item() { ItemType = ItemTypes.Weapon, Name = "Iron Axe", Quality = ItemQuality.Legendary, ItemLevel = 4 });
            items.Add(new Item() { ItemType = ItemTypes.Weapon, Name = "Iron Axe", Quality = ItemQuality.Legendary, ItemLevel = 6 });
            items.Add(new Item() { ItemType = ItemTypes.Weapon, Name = "Iron Axe", Quality = ItemQuality.Legendary, ItemLevel = 8 });
            items.Add(new Item() { ItemType = ItemTypes.Weapon, Name = "Iron Axe", Quality = ItemQuality.Legendary, ItemLevel = 10 });
            items.Add(new Item() { ItemType = ItemTypes.Weapon, Name = "Iron Axe", Quality = ItemQuality.Legendary, ItemLevel = 12 });
            items.Add(new Item() { ItemType = ItemTypes.Weapon, Name = "Iron Axe", Quality = ItemQuality.Legendary, ItemLevel = 14 });

            return items;
        }
    }
}
