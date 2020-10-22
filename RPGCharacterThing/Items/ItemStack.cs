using RPGCharacterThing.Items;

namespace RPGCharacterThing.Items
{
    public class ItemStack
    {
        public Item Item { get; private set; }
        public int Count;

        public ItemStack(Item item, int count=1)
        {
            this.Item = item;
            this.Count = count;
        }
    }
}