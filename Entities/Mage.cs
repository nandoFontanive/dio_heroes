using System;
namespace dio_heroes.Entities
{
    class Mage : Hero
    {
        public Mage(string title, string profession) : base(title, profession)
        {
            Title = title;
            Profession = profession;
            Level = 1;
            HealthPoints = 50;
            ManaPoints = 50;
        }

        public new string Attack()
        {
            Random die = new Random();
            int attackPower = Level + die.Next(1, 10);
            LastAttackPower = attackPower;
            return Title + " ataca com seu bastão e inflige " + attackPower + " de dano!";
        }

        public string Attack(int bonus)
        {
            Random die = new Random();
            int attackPower = Level + die.Next(1, 10) + bonus;
            LastAttackPower = attackPower;
            return Title + " ataca com bônus com seu bastão e inflige " + attackPower + " de dano!";
        }

    }
}
