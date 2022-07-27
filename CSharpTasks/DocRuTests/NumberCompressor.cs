using System.Linq;

namespace DocRuTests
{
    public static class NumberCompressor
    {
        /// <summary>
        /// Compresses the number to one-digit format, for example, 16 -> 1+6 -> 7, 56767 -> 5+6+7+6+7 -> 31 -> 3+1 -> 4
        /// </summary>
        /// <param name="inputNumber"></param>
        /// <returns> Compressed number if inputNumber is natural, otherwise inputNumber</returns>
        public static int GetCompressedNumber(int inputNumber)
        {
            if (inputNumber < 0)
                return inputNumber;

            int result = inputNumber;

            while(result / 10 >= 1)
            {
                string strTempResult = result.ToString();

                result = strTempResult.AsEnumerable().Select(chr => int.Parse(chr.ToString())).Sum();
            }

            return result;
        }
    }
}