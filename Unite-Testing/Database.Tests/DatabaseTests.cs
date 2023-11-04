using NUnit.Framework;
using System;

namespace Database.Tests
{
    public class DatabaseTests
    {
        private Database database;

        [SetUp]
        public void Setup()
        {
            var database = new Database(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 });
            this.database = database;
        }

        [Test]
        public void TestDatabaseCapacityWhenFull()
        {
            int element = 17;

            Assert.That(() => database.Add(element), Throws.InvalidOperationException
                .With.Message.EqualTo("Array's capacity must be exactly 16 integers!"));
        }

        [Test]
        public void TestDatabaseRemoveWhenCapacityEmpty()
        {
            for (int i = 0; i < 16; i++)
            {
                database.Remove();
            }

            Assert.That(() => database.Remove(), Throws.InvalidOperationException
                .With.Message.EqualTo("The collection is empty!"));
        }

        [Test]
        public void TestFetchReturnsElementsAsArray() 
        {
            int[] result = database.Fetch();

            Assert.IsInstanceOf<int[]>(result);
        }
    }
}