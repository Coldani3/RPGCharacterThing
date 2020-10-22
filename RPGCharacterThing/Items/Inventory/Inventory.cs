using RPGCharacterThing.Items;
using System.Collections.Generic;

namespace RPGCharacterThing.Items.Inventory
{
    public class Inventory
    {
        public List<Item> Contents = new List<Item>();

        public void AddItem(Item item)
        {
            Contents.Add(item);
        }

        public void RemoveItem(Item item)
        {
            Contents.Remove(item);
        }
    }
}