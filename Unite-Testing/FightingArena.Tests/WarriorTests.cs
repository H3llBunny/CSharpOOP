using NUnit.Framework;

namespace FightingArena.Tests
{
    public class WarriorTests
    {
        private string name;
        private int damage;
        private int hp;
        private const int MIN_ATTACK_HP = 30;

        [SetUp]
        public void Setup()
        {
            name = "warriorName";
            damage = 10;
            hp = 50;
        }

        [Test]
        public void WarriorNameIsNullOrWhiteSpace()
        {
            name = string.Empty;

            Assert.That(() => new Warrior(name, damage, hp), Throws.ArgumentException
                .With.Message.Contains("Name should not be empty or whitespace!"));
        }

        [Test]
        public void DamageIsZeroOrNegative()
        {
            damage = -1;

            Assert.That(() => new Warrior(name, damage, hp), Throws.ArgumentException
                .With.Message.Contains("Damage value should be positive!"));
        }

        [Test]
        public void HpShouldBePositive()
        {
            hp = -1;

            Assert.That(() => new Warrior(name, damage, hp), Throws.ArgumentException
                .With.Message.Contains("HP should not be negative!"));
        }

        [Test]
        public void YourHpIsLowerThan30()
        {
            hp = 30;
            var yourWarrior = new Warrior("yourName", damage, hp);
            var enemyWarrior = new Warrior("name", 10, 50);

            Assert.That(() => yourWarrior.Attack(enemyWarrior), Throws.InvalidOperationException
                .With.Message.Contains("Your HP is too low in order to attack other warriors!"));
        }

        [Test]
        public void EnemyHpIsLowerThan30()
        {
            var yourWarrior = new Warrior("yourName", damage, hp);
            var enemyWarrior = new Warrior("enemyWarrior", 10, 30);

            Assert.That(() => yourWarrior.Attack(enemyWarrior), Throws.InvalidOperationException
                .With.Message.Contains($"Enemy HP must be greater than {MIN_ATTACK_HP} in order to attack him!"));
        }

        [Test]
        public void EnemyIsStronger()
        {
            int enemyDamage = 60;
            var yourWarrior = new Warrior("yourName", damage, hp);
            var enemyWarrior = new Warrior("enemyWarrior", enemyDamage, hp);

            Assert.That(() => yourWarrior.Attack(enemyWarrior), Throws.InvalidOperationException
                .With.Message.EqualTo("You are trying to attack too strong enemy"));
        }

        [Test]
        public void YourWarriorAttacTakesDamage()
        {
            damage = 50;
            var yourWarrior = new Warrior("yourName", damage, hp);
            var enemyWarrior = new Warrior("enemyWarrior", damage, hp);

            yourWarrior.Attack(enemyWarrior);

            Assert.AreEqual(0, yourWarrior.HP);
        }

        [Test]
        public void YourWarriorAttacIsHigherThankEnemyHp()
        {
            damage = 50;
            var yourWarrior = new Warrior("yourName", damage + 1, hp);
            var enemyWarrior = new Warrior("enemyWarrior", damage, hp);

            yourWarrior.Attack(enemyWarrior);

            Assert.AreEqual(0, enemyWarrior.HP);
        }
    }
}