using Chainblock.Contracts;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;

namespace Chainblock.Tests
{
    [TestFixture]
    public class ChainblockTest
    {
        private IChainblock chainblock;
        private ITransaction tx1;
        private ITransaction tx2;
        private ITransaction tx3;
        private ITransaction tx4;
        [SetUp]
        public void Setup()
        {
            this.chainblock = new Chainblock();
            this.tx1 = new Transaction(1, TransactionStatus.Successfull, "Ivo", "Borko", 10);
            this.tx2 = new Transaction(2, TransactionStatus.Failed, "Blago", "Ivo", 20);
            this.tx3 = new Transaction(3, TransactionStatus.Aborted, "Borko", "Bota", 2);
            this.tx4 = new Transaction(4, TransactionStatus.Unauthorized, "Plamen", "Venci", 40);
        }

        [Test]
        public void Add_AddsTransactionToChainblock()
        {
            this.chainblock.Add(tx1);

            Assert.AreEqual(this.tx1, this.chainblock[0]);
        }

        [Test]
        public void Count_ReturnsCorrectCountAfterAddingTransaction()
        {
            this.chainblock.Add(tx1);

            Assert.AreEqual(1, this.chainblock.Count);
        }

        [Test]
        public void Contains_ReturnsTrueWhenTransactionExists()
        {
            this.chainblock.Add(tx1);

            Assert.True(this.chainblock.Contains(tx1));
        }

        [Test]
        public void Contains_ReturnsFalseWhenTransactionNotExists()
        {
            Assert.False(this.chainblock.Contains(tx1));
        }

        [Test]
        public void Contains_ReturnsTrueWhenIdExists()
        {
            this.chainblock.Add(tx1);

            Assert.True(this.chainblock.Contains(tx1.Id));
        }

        [Test]
        public void Contains_ReturnsFalseWhenIdNotExists()
        {
            Assert.False(this.chainblock.Contains(tx1.Id));
        }

        [Test]
        public void ChangeTransactionStatus_ChangesStatusOfExistingTransaction()
        {
            int id = 1;
            var newStatus = TransactionStatus.Failed;
            this.chainblock.Add(tx1);

            this.chainblock.ChangeTransactionStatus(id, newStatus);

            Assert.AreEqual(newStatus, this.chainblock[0].Status);
        }

        [Test]
        public void ChangeTransactionStatus_ThrowsArgumentExceptionWhenIdNotMatch()
        {
            int id = 2;
            var newStatus = TransactionStatus.Failed;
            this.chainblock.Add(tx1);

            Assert.Throws<ArgumentException>(() => this.chainblock.ChangeTransactionStatus(id, newStatus));
        }

        [Test]
        public void RemoveTransactionById_RemovesTransactionById()
        {
            this.chainblock.Add(tx1);
            this.chainblock.RemoveTransactionById(1);

            Assert.IsFalse(this.chainblock.Contains(tx1));
        }

        [Test]
        public void RemoveTransactionById_ThrowsInvalidOperationExceptionWhenNoIdMatch()
        {
            Assert.Throws<InvalidOperationException>(() => this.chainblock.RemoveTransactionById(1));
        }

        [Test]
        public void GetById_ReturnsTransactionById()
        {
            this.chainblock.Add(tx1);

            Assert.AreEqual(tx1, this.chainblock.GetById(tx1.Id));
        }

        [Test]
        public void GetById_ThrowsInvalidOperationExceptionWhenIdNoMatch()
        {
            Assert.Throws<InvalidOperationException>(() => this.chainblock.GetById(tx1.Id));
        }

        [Test]
        public void GetByTransactionStatus_ReturnsCollectionWithMatchingStatus()
        {
            this.chainblock.Add(tx1);
            var result = this.chainblock.GetByTransactionStatus(TransactionStatus.Successfull);

            Assert.True(result.Contains(tx1));
        }

        [Test]
        public void GetByTransactionStatus_ThrowsInvalidOperationExceptionWhenStatusNotFound()
        {
            Assert.Throws<InvalidOperationException>(() =>
            this.chainblock.GetByTransactionStatus(TransactionStatus.Successfull));
        }

        [Test]
        public void GetAllSendersWithTransactionStatus_ReturnsCollectionWithMatchingStatus()
        {
            this.tx2.Status = TransactionStatus.Successfull;
            this.chainblock.Add(tx2);
            this.chainblock.Add(tx1);

            var result = this.chainblock.GetAllSendersWithTransactionStatus(TransactionStatus.Successfull).ToList();

            Assert.AreEqual(tx2.From, result[0]);
        }

        [Test]
        public void GetAllSendersWithTransactionStatus_ThrowsInvalidOperationExceptionWhenNoMatch()
        {
            Assert.Throws<InvalidOperationException>(() =>
            this.chainblock.GetAllSendersWithTransactionStatus(TransactionStatus.Successfull));
        }

        [Test]
        public void GetAllReceiversWithTransactionStatus_ReturnsCollectionWithMatchingStatus()
        {
            this.tx2.Status = TransactionStatus.Successfull;
            this.chainblock.Add(tx2);
            this.chainblock.Add(tx1);

            var result = this.chainblock.GetAllReceiversWithTransactionStatus(TransactionStatus.Successfull).ToList();

            Assert.AreEqual(tx2.To, result[0]);
        }

        [Test]
        public void GetAllReceiversWithTransactionStatus_ThrowsInvalidOperationExceptionWhenNoMatch()
        {
            Assert.Throws<InvalidOperationException>(() =>
            this.chainblock.GetAllReceiversWithTransactionStatus(TransactionStatus.Successfull));
        }

        [Test]
        public void GetAllOrderedByAmountDescendingThenById_ReturnsOrderedCollection()
        {
            this.chainblock.Add(tx1);
            this.chainblock.Add(tx2);

            var result = this.chainblock.GetAllOrderedByAmountDescendingThenById().ToList();

            Assert.AreEqual(tx2, result[0]);
        }

        [Test]
        public void GetBySenderOrderedByAmountDescending_ReturnsOrderedCollection()
        {
            this.chainblock.Add(tx1);
            this.tx2.From = "Ivo";
            this.chainblock.Add(tx2);

            var result = this.chainblock.GetBySenderOrderedByAmountDescending("Ivo").ToList();

            Assert.AreEqual(tx2.Amount, result[0].Amount);
        }

        [Test]
        public void GetBySenderOrderedByAmountDescending_ThrowsInvalidOperationExceptionWhenNoSenderMatch()
        {
            Assert.Throws<InvalidOperationException>(() =>
            this.chainblock.GetBySenderOrderedByAmountDescending("RandomName"));
        }

        [Test]
        public void GetByReceiverOrderedByAmountThenById_ReturnsOrderedCollection()
        {
            this.chainblock.Add(tx1);
            this.tx2.To = "Borko";
            this.chainblock.Add(tx2);

            var result = this.chainblock.GetByReceiverOrderedByAmountThenById("Borko").ToList();

            Assert.AreEqual(tx2.To, result[0].To);
        }

        [Test]
        public void GetByReceiverOrderedByAmountThenById_ThrowsInvalidOperationExceptionWhenNoReceiverMatch()
        {
            Assert.Throws<InvalidOperationException>(() =>
            this.chainblock.GetByReceiverOrderedByAmountThenById("RandomName"));
        }

        [Test]
        public void GetByTransactionStatusAndMaximumAmount_ReturnsOrderedCollection()
        {
            this.chainblock.Add(tx1);
            this.tx2.Status = TransactionStatus.Successfull;
            this.chainblock.Add(tx2);

            var result = this.chainblock.GetByTransactionStatusAndMaximumAmount(TransactionStatus.Successfull, 20).ToList();

            Assert.AreEqual(this.tx2, result[0]);
        }

        [Test]
        public void GetByTransactionStatusAndMaximumAmount_ReturnsEmptyCollectionWhenNoStatusMatch()
        {
            var result = this.chainblock.GetByTransactionStatusAndMaximumAmount(TransactionStatus.Successfull, 20).ToList();

            Assert.IsEmpty(result);
        }

        [Test]
        public void GetBySenderAndMinimumAmountDescending_ReturnsOrderedCollection()
        {
            this.chainblock.Add(tx1);
            this.tx2.From = "Ivo";
            this.chainblock.Add(tx2);

            var result = this.chainblock.GetBySenderAndMinimumAmountDescending("Ivo", 9).ToList();

            Assert.AreEqual(tx2, result[0]);
        }

        [Test]
        public void GetBySenderAndMinimumAmountDescending_ThrowsInvalidOperationExceptionWhenNoSenderMatch()
        {
            Assert.Throws<InvalidOperationException>(() =>
            this.chainblock.GetBySenderAndMinimumAmountDescending("Ivo", 1));
        }

        [Test]
        public void GetBySenderAndMinimumAmountDescending_ThrowsInvalidOperationExceptionWhenAmountNotGreaterMatch()
        {
            this.chainblock.Add(tx1);
            this.tx2.From = "Ivo";
            this.chainblock.Add(tx2);

            Assert.Throws<InvalidOperationException>(() =>
            this.chainblock.GetBySenderAndMinimumAmountDescending("Ivo", 20));
        }

        [Test]
        public void GetByReceiverAndAmountRange_ReturnsOrderedCollection()
        {
            this.chainblock.Add(tx1);
            this.tx2.To = "Borko";
            this.chainblock.Add(tx2);

            var result = this.chainblock.GetByReceiverAndAmountRange("Borko", 10, 20).ToList();

            Assert.AreEqual(tx2, result[0]);
        }

        [Test]
        public void GetByReceiverAndAmountRange_ThrowsInvalidOperationExceptionWhenNoReceiverMatch()
        {
            this.chainblock.Add(tx1);
            this.tx2.To = "Borko";
            this.chainblock.Add(tx2);

            Assert.Throws<InvalidOperationException>(() =>
            this.chainblock.GetByReceiverAndAmountRange("Borko", 21, 30).ToList());
        }

        [Test]
        public void GetByReceiverAndAmountRange_ThrowsInvalidOperationExceptionWhenAmountNoMatchRange()
        {
            this.chainblock.Add(tx1);
            this.tx2.To = "Borko";
            this.chainblock.Add(tx2);

            Assert.Throws<InvalidOperationException>(() =>
            this.chainblock.GetByReceiverAndAmountRange("Ivo", 10, 20).ToList());
        }

        [Test]
        public void GetAllInAmountRange_ReturnsCollectionInAmountRange()
        {
            this.chainblock.Add(tx1);
            this.chainblock.Add(tx2);

            var testCollection = new Chainblock();
            testCollection.Add(tx1);
            testCollection.Add(tx2);

            var result = this.chainblock.GetAllInAmountRange(10, 20);

            Assert.AreEqual(testCollection, result);
        }

        [Test]
        public void GetAllInAmountRange_ReturnsEmptyCollectionWhenNoAmountMatch()
        {
            this.chainblock.Add(tx1);
            this.chainblock.Add(tx2);

            var result = this.chainblock.GetAllInAmountRange(21, 22);

            Assert.IsEmpty(result);
        }

        [Test]
        public void ITransactionInRangeIndex_ReturnsTransaction()
        {
            this.chainblock.Add(tx1);
            this.chainblock.Add(tx2);

            Assert.AreEqual(tx2, this.chainblock[1]);
        }

        [Test]
        public void Indexer_WhenIndexOutOfRange_ThrowsIndexOutOfRangeException()
        {
            this.chainblock.Add(tx1);
            this.chainblock.Add(tx2);

            Assert.Throws<IndexOutOfRangeException>(() => { var transaction = this.chainblock[2]; });
        }
    }
}
