using RPGCharacterThing.Items;
using System.Collections.Generic;

namespace RPGCharacterThing.Characters
{
    public class Enemy : Character
    {
        public List<Item> Drops = new List<Item>();

        public Enemy()
        {

        }
    }
}