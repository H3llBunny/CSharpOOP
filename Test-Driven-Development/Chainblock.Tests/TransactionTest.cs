using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chainblock.Tests
{
    [TestFixture]
    public class TransactionTest
    {
        [Test]
        public void CreatingATransaction()
        {
            TransactionStatus status = TransactionStatus.Successfull;
            Transaction transaction = new Transaction(1, status, "Pesho", "Gosho", 5);
        }
    }
}
