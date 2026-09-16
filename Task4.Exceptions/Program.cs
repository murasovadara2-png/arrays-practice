using System;

namespace Task4.Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Создаем массив из 5 элементов int
            int[] array = new int[5];

            // 2. Заполняем его с клавиатуры с обработкой исключений
            for (int i = 0; i < array.Length; i++)
            {
                while (true)
                {
                    try
                    {
                        Console.Write($"Введите элемент [{i}]: ");
                        array[i] = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Ошибка: Введите целое число!");
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Ошибка: Число слишком большое!");
                    }
                }
            }

            // 3. Запрос индекса для вывода и обработка IndexOutOfRangeException
            while (true)
            {
                try
                {
                    Console.Write($"Введите индекс для вывода (0-{array.Length - 1}): ");
                    int index = int.Parse(Console.ReadLine());
                    
                    // Попытка доступа к элементу (вызовет исключение, если индекс некорректен)
                    Console.WriteLine($"Значение элемента с индексом {index}: {array[index]}");
                    break; 
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка: Индекс должен быть целым числом!");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Ошибка: Индекс вне границ массива.");
                }
            }
        }
    }
}
