using System;
namespace dio_heroes.Entities
{
    class Hero
    {
        public string Title { get; set; }
        public int Level { get; set; }
        public int HealthPoints { get; set; }
        public int ManaPoints { get; set; }
        public string Profession { get; set; }
        public int LastAttackPower { get; set; }

        public Hero(string title, string profession)
        {
            Title = title;
            Profession = profession;
            Level = 1;
            HealthPoints = 50;
            ManaPoints = 50;
        }

        public override string ToString()
        {
            return "Meu nome é " + Title + "\n"
            + "Level: " + Level + "\n"
            + "Classe: " + Profession + "\n"
            + "Health points: " + HealthPoints + "\n"
            + "Mana points: " + ManaPoints + "\n";
        }
        public string Attack()
        {
            Random die = new Random();
            int attackPower = Level + die.Next(9, 20);
            LastAttackPower = attackPower;
            return Title + " ataca e inflige " + attackPower + " de dano.";
        }

        public void ReceiveDamage(int damageReceived)
        {
            HealthPoints =- damageReceived;
        }

    }
}
