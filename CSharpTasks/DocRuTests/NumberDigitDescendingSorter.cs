namespace DocRuTests
{
    public static class NumberDigitDescendingSorter
    {
        public static int GetSortedNumber(int inputNumber)
        {
            if (inputNumber <= 0)
                return inputNumber;

            var digitsFormattedList =  inputNumber.ToString().AsEnumerable().ToList();

            digitsFormattedList.Sort((a, b) => int.Parse(b.ToString()) - int.Parse(a.ToString()));

            return int.Parse(string.Join("", digitsFormattedList));
        }
    }
}
