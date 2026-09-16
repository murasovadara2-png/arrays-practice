using System;

namespace Task2.InputSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            // 1. Запрос корректного количества элементов
            while (true)
            {
                Console.Write("Введите количество элементов: ");
                if (int.TryParse(Console.ReadLine(), out n) && n > 0)
                {
                    break;
                }
                Console.WriteLine("Ошибка: введите целое число больше 0!");
            }

            int[] array = new int[n];

            // 2. Заполнение массива с обработкой FormatException и OverflowException
            for (int i = 0; i < n; i++)
            {
                while (true)
                {
                    try
                    {
                        Console.Write($"Элемент [{i}]: ");
                        array[i] = int.Parse(Console.ReadLine());
                        break; 
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Ошибка: Введите корректное целое число!");
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Ошибка: Число выходит за границы int!");
                    }
                }
            }

            // 3. Вывод в прямом порядке
            Console.WriteLine("Исходный массив: " + string.Join(", ", array));

            // 4. Вывод в обратном порядке
            Console.Write("Обратный порядок: ");
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write(array[i] + (i > 0 ? ", " : ""));
            }
            Console.WriteLine();

            // 6. Нахождение макс/мин элементов вручную (исправлено на array[0])
            int max = array[0];
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max) max = array[i];
                if (array[i] < min) min = array[i];
            }

            // 5. Сортировка по возрастанию и её вывод
            Array.Sort(array);
            Console.WriteLine("Отсортированный: " + string.Join(", ", array));
            
            Console.WriteLine($"Максимум: {max}");
            Console.WriteLine($"Минимум: {min}");
        }
    }
}
