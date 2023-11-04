using ExtendedDatabase;
using NUnit.Framework;
using System;
using System.Linq;

namespace ExtendedDatabase.Tests
{
    public class ExtendedDatabaseTests
    {
        private Person[] persons = new Person[16];
        private ExtendedDatabase extendedDatabase;

        [SetUp]
        public void Setup()
        {
            for (int i = 0; i < 16; i++)
            {
                int id = i + 1;
                string userName = "User " + id.ToString();

                this.persons[i] = new Person(id, userName);
            }

            var extendedDatabase = new ExtendedDatabase(persons);
            this.extendedDatabase = extendedDatabase;
        }

        [Test]
        public void AddRangeOutsideOfCapacity()
        {
            var persons = new Person[17];

            for (int i = 0; i < 17; i++)
            {
                int id = i + 1;
                string userName = "User " + id.ToString();

                persons[i] = new Person(id, userName);
            }
            Assert.That(() => extendedDatabase = new ExtendedDatabase(persons), Throws.ArgumentException
                .With.Message.EqualTo("Provided data length should be in range [0..16]!"));
        }

        [Test]
        public void AddNewUserWhenCapacityIsFull()
        {
            var existingPerson = new Person(17, "User 17");
            Assert.That(() => this.extendedDatabase.Add(existingPerson), Throws.InvalidOperationException
                .With.Message.EqualTo("Array's capacity must be exactly 16 integers!"));
        }

        [Test]
        public void AddAlreadyExistingUserByUsername()
        {
            extendedDatabase.Remove();
            Person existingUser = new Person(17, "User 1");

            Assert.That(() => extendedDatabase.Add(existingUser), Throws.InvalidOperationException
                .With.Message.EqualTo("There is already user with this username!"));
        }

        [Test]
        public void AddAlreadyExistingUserById()
        {
            extendedDatabase.Remove();
            Person existingUser = new Person(1, "User 17");

            Assert.That(() => extendedDatabase.Add(existingUser), Throws.InvalidOperationException
                .With.Message.EqualTo("There is already user with this Id!"));
        }

        [Test]
        public void RemoveWhenExtendedDatabaseIsEmpty()
        {
            for (int i = 0; i < 16; i++)
            {
                extendedDatabase.Remove();
            }

            Assert.That(() => extendedDatabase.Remove(), Throws.InvalidOperationException);
        }

        [Test]
        public void FindByUsernameIfUserIsNullOrEmpty()
        {
            string personName = string.Empty;
            Assert.That(() => extendedDatabase.FindByUsername(personName), Throws.ArgumentNullException
                .With.Message.Contain("Username parameter is null!"));
        }

        [Test]
        public void FindByUsernameWhenUserDoesNotExist()
        {
            Assert.That(() => extendedDatabase.FindByUsername("User 17"), Throws.InvalidOperationException
                .With.Message.EqualTo("No user is present by this username!"));
        }

        [Test]
        public void FindByUsernameIfNameIsCorrect()
        {
            string user = "User 1";
            Assert.That(() => extendedDatabase.FindByUsername(user), 
                Is.EqualTo(persons.FirstOrDefault(p => p.UserName == user)));
        }

        [Test]
        public void FindByIdIfNumberIsNegative()
        {
            Assert.That(() => extendedDatabase.FindById(-1), Throws.TypeOf<ArgumentOutOfRangeException>()
                .With.Message.Contains("Id should be a positive number!"));
        }

        [Test]
        public void FindByIdWhereIdIsInvalid()
        {
            Assert.That(() => extendedDatabase.FindById(17), Throws.InvalidOperationException
                .With.Message.EqualTo("No user is present by this ID!"));
        }

        [Test]
        public void FindByUserIdIfIdIsCorrect()
        {
            int userId = 1;
            Assert.That(() => extendedDatabase.FindById(userId),
                Is.EqualTo(persons.FirstOrDefault(p => p.Id == userId)));
        }
    }
}