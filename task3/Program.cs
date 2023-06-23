﻿// Задача 2: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

int Prompt(string message)
{
    System.Console.Write($"{message} > ");
    string inputedStr = Console.ReadLine();
    int value;
    if (int.TryParse(inputedStr, out value))
    {
        return value;
    }
    System.Console.WriteLine($"Извините, но '{inputedStr}' не является целым числом");
    Environment.Exit(0);
    return 0;
}


int[] GenerateArray(int len, int min, int max)
{
    int[] list1 = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < list1.Length; i++)
    {
        list1[i] = rnd.Next(min, max + 1);
    }
    return list1;
}

void PrintArray(int[] Arrey)
{
    for (int i = 0; i < Arrey.Length; i++)
    {
        System.Console.Write(Arrey[i] + "\t");
    }
    System.Console.WriteLine();
}

bool FindIsExist(int [] array, int num)
{
    for (int i=0;i<array.Length;i++)
    {
        if(num == array[i])
        return true;
    }
return false;
}

int[] numbers = GenerateArray(10,-10,100);
int number = Prompt("Введите число");
PrintArray(numbers);

int number = numint();

if (FindIsExist(numbers, number))
{
    System.Console.WriteLine("такое число есть в массиве");
}
else
{
    System.Console.WriteLine("Такого числа нет в массиве");
}

/*//Задача 2: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//3; массив [6, 7, 19, 345, 3] -> да

int numberint()                                 // Запрашивает число у пользователя и переводит его в int
{
    Console.Write("Введите число --> ");
    string numint = Console.ReadLine();
    int numberint = Convert.ToInt32(numint);
    return numberint;
}

int[] GenerateArray(int len, int min, int max)		// Создает и наполняет массив
{
    int[] list1 = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < list1.Length; i++)
    {
        list1[i] = rnd.Next(min, max + 1);
    }
    return list1;
}

bool poiskchisla(int[] array, int number)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(number == array[i])
        {
            return true;
        }
        
    }
    return false;
}  

void PrintArrey(int[] Arrey)				// Показывает в терминале массив
{
    for (int i = 0; i < Arrey.Length; i++)
    {
        System.Console.Write(Arrey[i] + " ");
    }
    System.Console.WriteLine();
}

int[] numberlist = GenerateArray(10, 0, 10);
PrintArrey(numberlist);

int number = numberint();

if(poiskchisla(numberlist, number))
{
    System.Console.WriteLine($"Такое число есть");
}
else
{
    System.Console.WriteLine($"Такого числа нет");
}*/