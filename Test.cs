using System;

class Program
{
    static void Main(string[] args)
    {
        // Ввод количества строк
        Console.Write("Введите количество строк: ");
        int n = int.Parse(Console.ReadLine());

        // Создание массива строк
        string[] originalArray = new string[n];

        // Ввод строк в массив
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Введите строку {i + 1}: ");
            originalArray[i] = Console.ReadLine();
        }

        // Создание нового массива для строк длиной <= 3 символов
        string[] newArray = new string[originalArray.Length]; // Максимальный размер равен исходному массиву

        // Переменная для отслеживания индекса в новом массиве
        int newIndex = 0;

        // Перебор строк в исходном массиве
        foreach (string str in originalArray)
        {
            // Удаление пробелов в начале и конце строки
            string trimmedStr = str.Trim();

            // Проверка длины строки
            if (trimmedStr.Length <= 3)
            {
                // Добавление строки в новый массив
                newArray[newIndex] = trimmedStr;
                newIndex++;
            }
        }

        // Создание нового массива нужного размера
        string[] finalArray = new string[newIndex];
        Array.Copy(newArray, finalArray, newIndex);

        // Вывод исходного массива
        Console.WriteLine("Исходный массив: [" + string.Join(", ", originalArray) + "]");

        // Вывод нового массива
        Console.WriteLine("Новый массив: [" + string.Join(", ", finalArray) + "]");
    }
}