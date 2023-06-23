// Задача 4: Найдите произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
//Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


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

void PrintArrey(int[] Arrey)				// Показывает в терминале массив
{
    for (int i = 0; i < Arrey.Length; i++)
    {
        System.Console.Write(Arrey[i] + " ");
    }
    System.Console.WriteLine();
}



int lenArr = Prompt("Введите длину массива");
int minArr = Prompt("Введите минимальный элемент массива");
int maxArr = Prompt("Введите максимальный элемент массива");
int[] numbers = GenerateArray(lenArr, minArr, maxArr);

PrintArrey(numbers);
System.Console.WriteLine();
int[] NumPr = new int[lenArr / 2 + lenArr % 2];
NumPr[NumPr.Length-1] = numbers[NumPr.Length-1];
for (int i = 0; i < numbers.Length/2; i++)
{
    NumPr[i] = numbers[i] * numbers[numbers.Length - i - 1];
}
NumPr[NumPr.Length-1] = numbers[NumPr.Length-1];

PrintArrey(NumPr);

/*//адача 4: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21

int numberint(string text)                                     // Запрашивает число у пользователя и переводит его в int
{
    System.Console.WriteLine(text);
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

void PrintArrey(int[] Arrey)				// Показывает в терминале массив
{
    for (int i = 0; i < Arrey.Length; i++)
    {
        System.Console.Write(Arrey[i] + " ");
    }
    System.Console.WriteLine();
}

int len = numberint("Введите длину массива");

int[] numberlist = GenerateArray(len, 1, 10);
PrintArrey(numberlist);

int[] list1 = new int[len / 2 + len % 2];

list1[list1.Length -1] = numberlist[list1.Length -1];

for (int i = 0; i < numberlist.Length /2; i++)
{
    list1[i] = numberlist[i] * numberlist[numberlist.Length - i - 1];
}

PrintArrey(list1);*/