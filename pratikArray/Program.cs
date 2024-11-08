using System;
using System.Linq;

class Program
{
    static void Main()
    {
        
        int[] numbers = new int[10];

        
        Console.WriteLine("10 adet tam sayı giriniz:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Sayı {i + 1}: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("\nGirilen sayılar:");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }

        
        Console.WriteLine("\n\nBir yeni tam sayı giriniz (11. eleman):");
        int newNumber = Convert.ToInt32(Console.ReadLine());
        numbers = numbers.Concat(new int[] { newNumber }).ToArray();

        
        Console.WriteLine("\nBüyükten küçüğe sıralanmış dizi:");
        Array.Sort(numbers);
        Array.Reverse(numbers);
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
    }
}

