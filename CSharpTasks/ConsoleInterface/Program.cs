// See https://aka.ms/new-console-template for more information
using DocRuTests;

namespace ConsoleInterface // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Запуск теста задачи 4 (сжатие числа)");
            WriteFormattedMessageForNumberCompressorTask(0, 0);
            WriteFormattedMessageForNumberCompressorTask(-15, -15);
            WriteFormattedMessageForNumberCompressorTask(5, 5);
            WriteFormattedMessageForNumberCompressorTask(16, 7);
            WriteFormattedMessageForNumberCompressorTask(23, 5);
            WriteFormattedMessageForNumberCompressorTask(357, 6);
            WriteFormattedMessageForNumberCompressorTask(4567, 4);
            WriteFormattedMessageForNumberCompressorTask(942, 6);
            WriteFormattedMessageForNumberCompressorTask(657567568, 1);


            Console.WriteLine("\nЗапуск теста задачи 5 (минимальный набор монет для суммы центов)");
            WriteFormattedMessageForCentsConverterTask(-1232);
            WriteFormattedMessageForCentsConverterTask(0);
            WriteFormattedMessageForCentsConverterTask(1);
            WriteFormattedMessageForCentsConverterTask(1232);
            WriteFormattedMessageForCentsConverterTask(567);
            WriteFormattedMessageForCentsConverterTask(45);
            WriteFormattedMessageForCentsConverterTask(56);
            WriteFormattedMessageForCentsConverterTask(56.3f);
            WriteFormattedMessageForCentsConverterTask(34545.9f);
            WriteFormattedMessageForCentsConverterTask(-41.2f);


            Console.WriteLine("\nЗапуск теста задачи 6 (сортировка разрядов в числе по убыванию)");
            WriteFormattedMessageForNumberDigitDescendingSorterTask(123456789, 987654321);
            WriteFormattedMessageForNumberDigitDescendingSorterTask(0, 0);
            WriteFormattedMessageForNumberDigitDescendingSorterTask(6, 6);
            WriteFormattedMessageForNumberDigitDescendingSorterTask(-123456789, -123456789);
            WriteFormattedMessageForNumberDigitDescendingSorterTask(8475647, 8776544);
            WriteFormattedMessageForNumberDigitDescendingSorterTask(508187, 887510);

            Console.WriteLine("\nЗапуск теста задачи 7 (суммирование данных пирамиды)");
            WriteFormattedMessageForPyramidOfNumbersTask(1, 1);
            WriteFormattedMessageForPyramidOfNumbersTask(2, 8);
            WriteFormattedMessageForPyramidOfNumbersTask(3, 27);
            WriteFormattedMessageForPyramidOfNumbersTask(4, 64);
            WriteFormattedMessageForPyramidOfNumbersTask(5, 125);
            WriteFormattedMessageForPyramidOfNumbersTask(0, null);
            WriteFormattedMessageForPyramidOfNumbersTask(6, null);
            WriteFormattedMessageForPyramidOfNumbersTask(-234, null);
            WriteFormattedMessageForPyramidOfNumbersTask(456, null);


            Console.WriteLine("\nЗапуск теста задачи 5 (функция, всегда возвращающая число 5)");
            Console.WriteLine($"Ожидаемое значение  5, фактическое полученное {AlwaysFiveReturner.ReturnFive()}");
        }

        static void WriteFormattedMessageForNumberCompressorTask(int testedValue, int expectedValue)
        {
            Console.WriteLine($"Значение на входе {testedValue}, ожидаемое значение: {expectedValue}, результат: {NumberCompressor.GetCompressedNumber(testedValue)}");
        }

        static void WriteFormattedMessageForCentsConverterTask(int testedValue)
        {
            Dictionary<CentsConverter.CoinNames, int> resultDictionary = CentsConverter.GetMinimalCoinsCountForCentsAmount(testedValue);

            Console.WriteLine($"\nДля тестируемого значения в {testedValue} центов нужное рассчетное количество монет: ");
            Console.WriteLine($"Quarters: {resultDictionary[CentsConverter.CoinNames.Quarters]}");
            Console.WriteLine($"Dimes: {resultDictionary[CentsConverter.CoinNames.Dimes]}");
            Console.WriteLine($"Nickels: {resultDictionary[CentsConverter.CoinNames.Nickels]}");
            Console.WriteLine($"Pennies: {resultDictionary[CentsConverter.CoinNames.Pennies]}\n");
        }

        static void WriteFormattedMessageForCentsConverterTask(float testedValue)
        {
            Dictionary<CentsConverter.CoinNames, int> resultDictionary = CentsConverter.GetMinimalCoinsCountForCentsAmount(testedValue);

            Console.WriteLine($"\nДля тестируемого значения в {testedValue} центов нужное рассчетное количество монет (дробная часть начального значения игнорируется): ");
            Console.WriteLine($"Quarters: {resultDictionary[CentsConverter.CoinNames.Quarters]}");
            Console.WriteLine($"Dimes: {resultDictionary[CentsConverter.CoinNames.Dimes]}");
            Console.WriteLine($"Nickels: {resultDictionary[CentsConverter.CoinNames.Nickels]}");
            Console.WriteLine($"Pennies: {resultDictionary[CentsConverter.CoinNames.Pennies]}\n");
        }

        static void WriteFormattedMessageForNumberDigitDescendingSorterTask(int testedValue, int expectedValue)
        {
            Console.WriteLine($"Значение на входе {testedValue}, ожидаемое значение: {expectedValue}, результат: {NumberDigitDescendingSorter.GetSortedNumber(testedValue)}");
        }

        static void WriteFormattedMessageForPyramidOfNumbersTask(int inputValue, int? expectedValue)
        {
            try
            {
                PyramidOfNumbers pyramidInstance = new PyramidOfNumbers();

                int resultValue = pyramidInstance.GetSumOfTheSpecificFloor(inputValue);

                Console.WriteLine($"Значение на входе {inputValue}, ожидаемое значение: {expectedValue}, результат: {resultValue}");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine($"Для входного значения {inputValue} выбрасывается исключение \"Индекс за пределами диапазона\"");
            }
        }
    }
}