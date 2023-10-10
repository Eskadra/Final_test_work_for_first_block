using System;

class Program
{
    static void Main()
    {
        // Ввод массива с клавиатуры
        Console.WriteLine("Введите элементы массива через пробел:");
        string[] inputArray = Console.ReadLine().Split(' ');

        // Создание нового массива, содержащего только строки длиной не более 3 символов
        string[] resultArray = new string[inputArray.Length];
        int count = 0;
        

        foreach (string item in inputArray)
        {
            if (item.Length <= 3)
            {
                resultArray[count] = item;
                count++;
            }
        }

        // Вывод нового массива
        Console.WriteLine("Новый массив:");
        Console.WriteLine("[{0}]", string.Join(", ", resultArray));
    }
}
