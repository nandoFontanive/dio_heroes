using System;
namespace dio_heroes.Entities
{
    class Enemy : Hero
    {
        public Enemy(string title, string profession) : base(title, profession)
        {
            Title = title;
            Profession = profession;
            Level = 1;
            HealthPoints = 80;
            ManaPoints = 0;
        }

        public new string Attack()
        {
            Random die = new Random();
            int attackPower = Level + die.Next(1, 15);
            LastAttackPower = attackPower;
            return Title + " ataca e inflige " + attackPower + " de dano!";
        }

    }
}
