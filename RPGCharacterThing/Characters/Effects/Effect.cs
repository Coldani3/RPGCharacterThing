namespace RPGCharacterThing.Characters.Effects
{
    public abstract class Effect
    {
        public abstract void Apply();
        public abstract void Unapply();

        //TODO: Event based stuff like OnDamage, OnHeal, etc.
    }
}