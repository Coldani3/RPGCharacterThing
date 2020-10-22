using RPGCharacterThing.Characters;

namespace RPGCharacterThing.Items
{
    public abstract class Item
    {
        public string Name;
        //Returns true if this item can be used on a character
        public virtual bool CanBeUsedOnSelf { get; set; }
        public virtual bool CanBeUsedOnOthers { get; set; }

        public Item(string name)
        {
            this.Name = name;
        }
        
        ///<summary>Uses the item</summary>
        ///<param name="character">The character using this item.</param>
        ///<returns>True if successful</returns>
        public abstract bool Use(Character character);

        ///<summary>Uses the item on another character</summary>
        ///<param name="character">The character being targeted by this item.</param>
        ///<returns>True if successful</returns>
        public abstract bool UseOn(Character character);
    }
}