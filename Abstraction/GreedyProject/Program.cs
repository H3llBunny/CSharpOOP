namespace GreedyProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long bagCapacity = long.Parse(Console.ReadLine());
            var items = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            long goldAmount = 0;
            var gemsAmount = new Gem();
            var cashAmount = new Cash();
            bool goldCheck = false;

            for (int i = 0; i < items.Length; i++)
            {
                string item = GetItemType(items[i]);
                long amount = long.Parse(items[i + 1]);
                switch (item)
                {
                    case "Gold":
                        goldAmount += TryAddGoldInBag(amount, goldAmount, gemsAmount, cashAmount, bagCapacity);
                        goldCheck = true;
                        break;

                    case "Gem":
                        string gemName = items[i];
                        TryAddGemInBag(gemName, amount, goldAmount, gemsAmount, cashAmount, bagCapacity, goldCheck);
                        break;

                    case "Cash":
                        string currency = items[i];
                        TryAddCashInBag(currency, amount, goldAmount, gemsAmount, cashAmount, bagCapacity, goldCheck);
                        break;
                }

                i++;
            }

            if (goldCheck)
            {
                Console.WriteLine($"<Gold> ${goldAmount}\n##Gold - {goldAmount}");
            }

            if (gemsAmount.Gems.Keys.Count > 0)
            {
                Console.WriteLine($"<Gem> ${gemsAmount.Gems.Values.Sum()}");

                foreach (var item in gemsAmount.Gems.OrderByDescending(x => x.Key).ThenBy(x => x.Value))
                {
                    Console.WriteLine($"##{item.Key} - {item.Value}");
                }
            }

            if (cashAmount.CashCurrencies.Keys.Count > 0)
            {
                Console.WriteLine($"<Cash> ${cashAmount.CashCurrencies.Values.Sum()}");

                foreach (var currency in cashAmount.CashCurrencies.OrderByDescending(x => x.Key).ThenBy(x => x.Value))
                {
                    Console.WriteLine($"##{currency.Key} - {currency.Value}");
                }
            }
        }

        public static string GetItemType(string item)
        {
            if (item.ToLower() == "gold")
            {
                return "Gold";
            }
            else if (item.ToLower().EndsWith("gem") && item.Length >= 4)
            {
                return "Gem";
            }
            else if (item.Length == 3)
            {
                return "Cash";
            }

            return "null";
        }

        public static long TryAddGoldInBag(long amount, long goldAmount, Gem gemsAmount, Cash cashAmount, long bagCapacity)
        {
            if (amount + goldAmount + gemsAmount.Gems.Values.Sum()
                        + cashAmount.CashCurrencies.Values.Sum() <= bagCapacity)
            {
                return amount;
            }
            else
            {
                return 0;
            }
        }

        public static void TryAddGemInBag(string gemName, long amount, long goldAmount, Gem gemsAmount, Cash cashAmount, long bagCapacity, bool goldCheck)
        {
            long gemSum = gemsAmount.Gems.Values.Sum();
            long cashSum = cashAmount.CashCurrencies.Values.Sum();

            if (goldCheck && gemsAmount.Gems.ContainsKey(gemName) && amount + gemSum <= goldAmount
                && amount + goldAmount + gemSum + cashSum <= bagCapacity)
            {
                gemsAmount.Gems[gemName] += amount;
            }
            else if (goldCheck && amount + gemSum <= goldAmount
                && amount + goldAmount + gemSum + cashSum <= bagCapacity)
            {
                gemsAmount.Add(gemName, amount);
            }
        }

        public static void TryAddCashInBag(string currency, long amount, long goldAmount, Gem gemsAmount, Cash cashAmount, long bagCapacity, bool goldCheck)
        {
            long gemSum = gemsAmount.Gems.Values.Sum();
            long cashSum = cashAmount.CashCurrencies.Values.Sum();

            if (gemsAmount.Gems.Count > 0 && goldCheck && cashAmount.CashCurrencies.ContainsKey(currency) && amount + goldAmount
                + gemSum + cashSum <= bagCapacity
                && amount + cashSum <= gemSum)
            {
                cashAmount.CashCurrencies[currency] += amount;
            }
            else if (gemsAmount.Gems.Count > 0 && amount + goldAmount + gemSum + cashSum <= bagCapacity
                && amount + cashSum <= gemSum)
            {
                cashAmount.Add(currency, amount);
            }
        }
    }
}