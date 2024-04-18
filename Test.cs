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

        // Подсчет количества строк, удовлетворяющих условию
        int count = 0;
        foreach (string str in originalArray)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }

        // Создание нового массива из строк, длина которых <= 3 символам
        string[] newArray = new string[count];
        int index = 0;
        foreach (string str in originalArray)
        {
            if (str.Length <= 3)
            {
                newArray[index] = str;
                index++;
            }
        }

        // Вывод нового массива строк
        Console.WriteLine("Новый массив строк:");
        foreach (string str in newArray)
        {
            Console.WriteLine(str);
        }
    }
}