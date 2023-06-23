// Задача 1: Напишите программу замены элементов массива: 
//положительные элементы замените на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]


int number = new Random().Next(-10, 11); //создается рандомное число
    System.Console.WriteLine($"Ваше число {number}"); // вывод рандомного числа
    int a = number % 10; // цифру 1 до 9
    int b = number/10; // десяток
    if (a > b){
        System.Console.WriteLine(a);
    }
    else {
        System.Console.WriteLine(b);
    }

int[] GenerateArray(int len, int min, int max)
{
    int[] answer = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < answer.Length; i++)
    {
        answer[i] = rnd.Next(min, max + 1);
    }
    return answer;
}

void PrintArray(int[] array)
{
    foreach (int item in array)
    {
        System.Console.Write(item + "\t");
    }
    System.Console.WriteLine();
}

int[] ReverseArray(int[] input)
{
    for(int i = 0; i<input.Length; i++)
    {
        input[i] *=-1;
    }
    return input;
}

int[] newArray = (10, -10, 10);
PrintArray(newArray);
System.Console.WriteLine();
int[] reverse = ReverseArray(newArray);
PrintArray(newArray);

/*// Задача 1: Напишите программу замены 
//элементов массива: положительные элементы 
//замените на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]

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

int [] ReverseArray(int[] input)
{
    for(int index = 0; index < input.Length; index++)
    {
        input [index] = input [index] * -1;
    }
    return input;
}

void PrintArray(int[] Arrey)
{
    for (int i = 0; i < Arrey.Length; i++)
    {
        System.Console.Write(Arrey[i] + "\t");
    }
}

int[] newArray = GenerateArray(10, -10, 10);
PrintArray(newArray);
Console.WriteLine();
int[] reverse = ReverseArray(newArray);
PrintArray(reverse);*/