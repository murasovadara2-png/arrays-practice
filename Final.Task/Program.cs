using System;

namespace Final.Task
{
    class Program
    {
        static void Main(string[] args)
        {
            // Вариант 2. Палиндром
            Console.Write("Введите массив (числа через пробел): ");
            string input = Console.ReadLine();
            
            // Разделяем строку по пробелам и удаляем пустые элементы
            string[] tokens = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            
            if (tokens.Length == 0)
            {
                Console.WriteLine("Массив пуст.");
                return;
            }

            // Переводим массив строк в массив чисел
            int[] array = new int[tokens.Length];
            for (int i = 0; i < tokens.Length; i++)
            {
                if (!int.TryParse(tokens[i], out array[i]))
                {
                    Console.WriteLine("Ошибка: строка содержит некорректные числа!");
                    return;
                }
            }

            // Проверка на палиндром
            bool isPalindrome = true;
            for (int i = 0; i < array.Length / 2; i++)
            {
                // Сравниваем симметричные элементы: первый с последним, второй с предпоследним и т.д.
                if (array[i] != array[array.Length - 1 - i])
                {
                    isPalindrome = false;
                    break;
                }
            }

            // Вывод результата
            if (isPalindrome)
            {
                Console.WriteLine("Массив — палиндром");
            }
            else
            {
                Console.WriteLine("Массив — НЕ палиндром");
            }
        }
    }
}
