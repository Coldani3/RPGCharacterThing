using System;

namespace RPGCharacterThing.Characters.Stats
{
    public class Modifiers
    {
        public static readonly int NO_VALUE = -12491625;
        public double AttackMod;
        public double DefenseMod;
        public double SpeedMod;
        public double IntelligenceMod;
        public double CharismaMod;
        public double SizeMod;
        ///<summary>The modifier with the highest Priority will be applied first.</summary>
        public int Priority = 0;

        public bool Multiplicative = false;
        //Drops by 1 every turn. If it hits 0, the modifier is cleared.
        public int TurnsDuration;

        ///<remarks>For values you do not want for there to be a modifier for, set them to Modifiers.NO_VALUE</remarks>
        public Modifiers(double attackMod, double defenseMod, double speedMod, double intelligenceMod, double charismaMod, double sizeMod, bool multiplicative, int duration)
        {
            this.Multiplicative = multiplicative;
            this.AttackMod = SetValsEasy(attackMod);
            this.DefenseMod = SetValsEasy(defenseMod);
            this.SpeedMod = SetValsEasy(speedMod);
            this.IntelligenceMod = SetValsEasy(intelligenceMod);
            this.CharismaMod = SetValsEasy(charismaMod);
            this.SizeMod = SetValsEasy(sizeMod);
            this.TurnsDuration = duration;
        }

        private double SetValsEasy(double val)
        {
            return val == NO_VALUE ? (this.Multiplicative ? 1 : 0) : val;
        }

        public void ApplyMod(ref int original, double modifier)
        {
            if (this.Multiplicative)
            {
                original = (int) Math.Floor(original * modifier);
            }
            else
            {
                original = (int) Math.Floor(original + modifier);
            }
        }
    }
}