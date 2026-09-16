using System;

namespace Task1.Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем объект Random и массив из 10 элементов
            Random rand = new Random();
            int[] numbers = new int[10];

            // Заполняем массив случайными числами от 1 до 100
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rand.Next(1, 101); // 101 не включается
            }

            // Выводим массив в одну строку через string.Join
            Console.WriteLine("Массив: " + string.Join(", ", numbers));

            // Находим сумму, произведение и количество чётных чисел
            int sum = 0;
            double product = 1.0; // double предохраняет от переполнения
            int evenCount = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
                product *= numbers[i];
                
                if (numbers[i] % 2 == 0)
                {
                    evenCount++;
                }
            }

            // Находим среднее арифметическое
            double average = (double)sum / numbers.Length;

            // Считаем количество элементов больше среднего арифметического
            int greaterThanAverageCount = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > average)
                {
                    greaterThanAverageCount++;
                }
            }

            // Выводим все собранные данные на экран
            Console.WriteLine($"Сумма: {sum}");
            Console.WriteLine($"Произведение: {product:1.23E+15}"); 
            Console.WriteLine($"Чётных чисел: {evenCount}");
            Console.WriteLine($"Больше среднего ({average:F1}): {greaterThanAverageCount}");
        }
    }
}
