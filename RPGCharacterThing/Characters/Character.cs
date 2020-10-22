using RPGCharacterThing.Characters.Races;
using RPGCharacterThing.Items.Armour;
using RPGCharacterThing.Characters.Effects;
using System.Collections.Generic;

namespace RPGCharacterThing.Characters
{
    public abstract class Character
    {
        public string Name;
        public Race Race;
        public int DefaultHealth;
        public int DefaultIntelligence;
        public int DefaultCharisma;
        public int DefaultAttack;
        public int DefaultDefense;
        public int DefaultSpeed;
        public int DefaultSize;

        public int CurrentAttack;
        public int CurrentDefense;
        public int CurrentSpeed;
        public int CurrentIntelligence;
        public int CurrentCharisma;
        public int CurrentSize;
        //TODO: Armour for all limbs?
        public Armour Armour;
        public List<Effect> CurrentEffects = new List<Effect>();

        public void TakeDamage(int damage)
        {

        }

        public void BeHealed(int healed)
        {
            
        }
    }
}