namespace DocRuTests
{
    public static class CentsConverter
    {
        public enum CoinNames
        {
            Pennies = 1,
            Nickels = 5,
            Dimes = 10,
            Quarters = 25
        }

        public static Dictionary<CoinNames, int> GetMinimalCoinsCountForCentsAmount(int cents)
        {
            if (cents <= 0)
                return CreateCoinsDictionary(0, 0, 0, 0);

            int restOfCents = cents;

            int quarters = restOfCents / (int)CoinNames.Quarters;
            restOfCents %= (int)CoinNames.Quarters;
            int dimes = restOfCents / (int)CoinNames.Dimes;
            restOfCents %= (int)CoinNames.Dimes;
            int nickels = restOfCents / (int)CoinNames.Nickels;
            restOfCents %= (int)CoinNames.Nickels;

            return CreateCoinsDictionary(quarters, dimes, nickels, restOfCents);
        }

        public static Dictionary<CoinNames, int> GetMinimalCoinsCountForCentsAmount(float cents)
        {
            return GetMinimalCoinsCountForCentsAmount((int)Math.Floor(cents));
        }


        private static Dictionary<CoinNames, int> CreateCoinsDictionary(int quarters, int dimes, int nickels, int pennies)
        {
            Dictionary<CoinNames, int> resultDictionary = new Dictionary<CoinNames, int>();

            resultDictionary.Add(CoinNames.Quarters, quarters);
            resultDictionary.Add(CoinNames.Dimes, dimes);
            resultDictionary.Add(CoinNames.Nickels, nickels);
            resultDictionary.Add(CoinNames.Pennies, pennies);

            return resultDictionary;
        }
    }
}
