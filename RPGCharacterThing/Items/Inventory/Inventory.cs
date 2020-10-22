using RPGCharacterThing.Items;
using System.Collections.Generic;
using System.Linq;

namespace RPGCharacterThing.Items.Inventory
{
    public class Inventory
    {
        public List<ItemStack> Contents = new List<ItemStack>();

        public void AddItem(ItemStack item)
        {
            if (!this.HasItem(item)) Contents.Add(item);
            else GetMatchingItemStack(item).Count += item.Count;
        }

        public void AddItem(Item item)
        {
            if (!HasItem(item)) Contents.Add(new ItemStack(item));
        }

        public void RemoveItem(Item item)
        {
            Contents.;
        }

        public bool HasItem(Item item)
        {
            return Contents.Any((x) => x.Item == item);
        }

        public ItemStack GetMatchingItemStack(ItemStack itemStack)
        {
            return GetMatchingItemStack(itemStack.Item);
        }

        public ItemStack GetMatchingItemStack(Item item)
        {
            return Contents.Find((x) => x.Item == item);
        }
    }
}