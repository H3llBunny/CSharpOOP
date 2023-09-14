namespace Raiding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var heroesNum = int.Parse(Console.ReadLine());
            var counter = heroesNum;
            heroesNum = 0;
            var heroes = new List<IHero>();

            while (heroesNum != counter)
            {
                var heroName = Console.ReadLine();
                var classType = Console.ReadLine();

                switch (classType)
                {
                    case "Druid":
                        heroes.Add(new Druid(heroName));
                        heroesNum++;
                        break;

                    case "Paladin":
                        heroes.Add(new Paladin(heroName));
                        heroesNum++;
                        break;

                    case "Rogue":
                        heroes.Add(new Rogue(heroName));
                        heroesNum++;
                        break;

                    case "Warrior":
                        heroes.Add(new Warrior(heroName));
                        heroesNum++;
                        break;

                    default:
                        Console.WriteLine("Invalid hero!");
                        break;
                }
            }

            var bossHealth = int.Parse(Console.ReadLine());

            if (bossHealth <= heroes.Sum(x => x.Power))
            {
                foreach (var hero in heroes)
                {
                    Console.WriteLine(hero.CastAbility());
                }

                Console.WriteLine("Victory!");
            }
            else
            {
                foreach (var hero in heroes)
                {
                    Console.WriteLine(hero.CastAbility());
                }

                Console.WriteLine("Defeat...");
            }
        }
    }
}