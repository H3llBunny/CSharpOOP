using FightingArena;
using NUnit.Framework;
using System.Linq;

namespace FightingArena.Tests
{
    public class ArenaTests
    {
        private string firstWarrier;
        private string secondWarrier;
        private int damage = 10;
        private int hp = 50;
        Arena arena;

        [SetUp]
        public void Setup()
        {
            firstWarrier = "warrior1";
            secondWarrier = "warrior2";

            var arena = new Arena();
            this.arena = arena;
        }

        [Test]
        public void EnrollAlreadyExistingWarrior()
        {
            var warrior1 = new Warrior(firstWarrier, damage, hp);

            arena.Enroll(warrior1);

            Assert.That(() => arena.Enroll(warrior1), Throws.InvalidOperationException
                .With.Message.Contains("Warrior is already enrolled for the fights!"));
        }

        [Test]
        public void FightInvalidAttackerName()
        {
            firstWarrier = "invalidName";
            arena.Enroll(new Warrior(secondWarrier, damage, hp));

            Assert.That(() => arena.Fight(firstWarrier, secondWarrier), Throws.InvalidOperationException
                .With.Message.EqualTo($"There is no fighter with name {firstWarrier} enrolled for the fights!"));
        }

        [Test]
        public void FightInvalidDefenderName()
        {
            secondWarrier = "invalidName";
            arena.Enroll(new Warrior(firstWarrier, damage, hp));

            Assert.That(() => arena.Fight(firstWarrier, secondWarrier), Throws.InvalidOperationException
                .With.Message.EqualTo($"There is no fighter with name {secondWarrier} enrolled for the fights!"));
        }

        [Test]
        public void AttackerAttacksDefender()
        {
            arena.Enroll(new Warrior(firstWarrier, damage, hp));
            arena.Enroll(new Warrior(secondWarrier, damage, hp));

            arena.Fight(firstWarrier, secondWarrier);

            var defender = arena.Warriors.FirstOrDefault(w => w.Name == secondWarrier);
            Assert.Less(defender.HP, 50);
        }

        [Test]
        public void WarriorsCount()
        {
            arena.Enroll(new Warrior(firstWarrier, damage, hp));
            arena.Enroll(new Warrior(secondWarrier, damage, hp));

            Assert.AreEqual(arena.Count, 2);
        }
    }
}
