using Chainblock.Contracts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chainblock
{
    public class Chainblock : IChainblock
    {
        List<ITransaction> chainblock;

        public Chainblock()
        {
            this.chainblock = new List<ITransaction>();
        }

        public int Count { get => this.chainblock.Count; }

        public void Add(ITransaction tx)
        {
            this.chainblock.Add(tx);
        }

        public bool Contains(ITransaction tx)
        {
            return this.chainblock.Any(t => t == tx);
        }

        public bool Contains(int id)
        {
            return this.chainblock.Any(t => t.Id == id);
        }
        public void ChangeTransactionStatus(int id, TransactionStatus newStatus)
        {
            if (this.chainblock.Any(t => t.Id == id))
            {
                var tx = this.chainblock.FirstOrDefault(t => t.Id == id);
                tx.Status = newStatus;
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public void RemoveTransactionById(int id)
        {
            if (this.chainblock.Any(t => t.Id == id))
            {
                var tx = this.chainblock.FirstOrDefault(t => t.Id == id);
                this.chainblock.Remove(tx);
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public ITransaction GetById(int id)
        {
            if (this.chainblock.Any(t => t.Id == id))
            {
                var transaction = this.chainblock.FirstOrDefault(t => t.Id == id);
                return transaction;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public IEnumerable<ITransaction> GetByTransactionStatus(TransactionStatus status)
        {
            if (this.chainblock.Any(t => t.Status == status))
            {
                var wantedTransactions = this.chainblock.Where(t => t.Status == status);

                return wantedTransactions;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public IEnumerable<string> GetAllSendersWithTransactionStatus(TransactionStatus status)
        {
            if (this.chainblock.Any(t => t.Status == status))
            {
                var sendersList = new List<string>();
                var orderedList = this.chainblock.OrderByDescending(t => t.Amount);

                foreach (var tx in orderedList)
                {
                    if (tx.Status == status)
                    {
                        sendersList.Add(tx.From);
                    }
                }

                return sendersList;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public IEnumerable<string> GetAllReceiversWithTransactionStatus(TransactionStatus status)
        {
            if (this.chainblock.Any(t => t.Status == status))
            {
                var receiversList = new List<string>();
                var orderedList = this.chainblock.OrderByDescending(t => t.Amount);

                foreach (var tx in orderedList)
                {
                    if (tx.Status == status)
                    {
                        receiversList.Add(tx.To);
                    }
                }

                return receiversList;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public IEnumerable<ITransaction> GetAllOrderedByAmountDescendingThenById()
        {
            var orderedList = this.chainblock.OrderByDescending(t => t.Amount).ThenBy(t => t.Id);
            return orderedList;
        }

        public IEnumerable<ITransaction> GetBySenderOrderedByAmountDescending(string sender)
        {
            if (this.chainblock.Any(t => t.From == sender))
            {
                var orderedList = new List<ITransaction>();
                orderedList = this.chainblock.Where(t => t.From == sender).OrderByDescending(t => t.Amount).ToList();

                return orderedList;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public IEnumerable<ITransaction> GetByReceiverOrderedByAmountThenById(string receiver)
        {
            if (this.chainblock.Any(t => t.To == receiver))
            {
                var orderedList = this.chainblock.Where(t => t.To == receiver)
               .OrderByDescending(t => t.Amount).ThenBy(t => t.Id);

                return orderedList;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public IEnumerable<ITransaction> GetByTransactionStatusAndMaximumAmount(TransactionStatus status, double amount)
        {
            var filteredAndOrderedList = this.chainblock.Where(t => t.Status == status
            && t.Amount <= amount).OrderByDescending(t => t.Amount);

            return filteredAndOrderedList;
        }

        public IEnumerable<ITransaction> GetBySenderAndMinimumAmountDescending(string sender, double amount)
        {
            if (this.chainblock.Any(t => t.To == sender && t.Amount > amount))
            {
                var filteredAndOrderedList = this.chainblock.Where(
                    t => t.From == sender && t.Amount > amount).OrderByDescending(t => t.Amount);

                return filteredAndOrderedList;
            }
            else
            {
                throw new InvalidOperationException();
            }

        }

        public IEnumerable<ITransaction> GetByReceiverAndAmountRange(string receiver, double lo, double hi)
        {
            if (this.chainblock.Any(t => t.To == receiver
            && t.Amount >= lo && t.Amount <= hi))
            {
                var filteredAndOrderedList = this.chainblock.Where(t => t.To == receiver
                && t.Amount >= lo && t.Amount <= hi).OrderByDescending(t => t.Amount)
                .ThenBy(t => t.Id);

                return filteredAndOrderedList;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public IEnumerable<ITransaction> GetAllInAmountRange(double lo, double hi)
        {
            var filteredList = this.chainblock.Where(t => t.Amount >= lo
            && t.Amount <= hi);

            return filteredList;
        }

        public ITransaction this[int index]
        {
            get
            {
                if (index < 0 || index >= this.chainblock.Count)
                {
                    throw new IndexOutOfRangeException();
                }

                return this.chainblock[index];
            }
        }

        public IEnumerator<ITransaction> GetEnumerator()
        {
            foreach (var transaction in this.chainblock)
            {
                yield return transaction;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
