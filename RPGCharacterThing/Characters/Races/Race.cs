namespace RPGCharacterThing.Characters.Races
{
    public abstract class Race
    {
        public string Name;
        //TODO: Base stats for Race

        public Race(string name)
        {
            this.Name = name;
        }
    }
}