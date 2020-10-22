using RPGCharacterThing.Characters.Races;
using RPGCharacterThing.Items.Armour;
using RPGCharacterThing.Characters.Effects;
using RPGCharacterThing.Characters.Stats;
using System.Collections.Generic;
using System;
using System.Linq;

namespace RPGCharacterThing.Characters
{
    public abstract class Character
    {
        public string Name;
        public Race Race;
        public int MaxHealth;
        public int DefaultAttack;
        public int DefaultDefense;
        public int DefaultSpeed;
        public int DefaultIntelligence;
        public int DefaultCharisma;
        public int DefaultSize;

        public int CurrentHealth;
        public int CurrentAttack;
        public int CurrentDefense;
        public int CurrentSpeed;
        public int CurrentIntelligence;
        public int CurrentCharisma;
        public int CurrentSize;
        //TODO: Armour for all limbs?
        public Armour Armour;
        public List<Effect> CurrentEffects = new List<Effect>();
        public List<Modifiers> CurrentModifiers = new List<Modifiers>();

        public void TakeDamage(int damage)
        {
            this.CurrentHealth = Math.Clamp(this.CurrentHealth - damage, this.MaxHealth, 0);
        }

        public void BeHealed(int healed)
        {
            this.CurrentHealth = Math.Clamp(this.CurrentHealth + healed, this.MaxHealth, 0);
        }

        ///<remarks>Called at the end of every turn only.</remarks>
        public void Update()
        {
            UpdateStats();
        }

        ///<remarks>Called whenever a new modifier is added and at the end of every turn.</remarks>
        public void UpdateStats()
        {
            CurrentModifiers.OrderByDescending((x) => x.Priority).ToList().ForEach((x) => {
                x.ApplyMod(ref this.CurrentAttack, x.AttackMod);
                x.ApplyMod(ref this.CurrentDefense, x.DefenseMod);
                x.ApplyMod(ref this.CurrentSpeed, x.SpeedMod);
                x.ApplyMod(ref this.CurrentIntelligence, x.IntelligenceMod);
                x.ApplyMod(ref this.CurrentCharisma, x.CharismaMod);
                x.ApplyMod(ref this.CurrentSize, x.SizeMod);
            });
        }
    }
}