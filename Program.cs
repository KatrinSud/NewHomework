// Задача 1: Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа
//  в промежутке от M до N. Использовать рекурсию, не использовать циклы.

// int firstElement = 4;
// int secondElements = 15;

// PrintNumbers(firstElement,secondElements);

// void PrintNumbers(int startElement,int endElement)
// {
//    System.Console.WriteLine(startElement);

//    if(endElement <= startElement)
//    {
//       return;
//    }

//    PrintNumbers(startElement+1, endElement);
// }



// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.


int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");

int functionAkkerman = Ack(m, n);

Console.Write($"Функция Аккермана = {functionAkkerman} ");

int Ack(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Ack(m - 1, 1);
  else return Ack(m - 1, Ack(m, n - 1));
 }

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = int.Parse(Console.ReadLine());
  return output;
}


// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.


Console.WriteLine("Введите размер массива");
int userLength = int.Parse(Console.ReadLine());
int[] userArray = CreateArray(userLength);

int[] CreateArray (int length)
{
    Random random = new Random();
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(1,11);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
    }
}

void PrintReversArray (int [] array, int length)
{
    if (length ==1)
    {
        Console.Write($"{array[0]}");
    }
    else
    {
        Console.Write($"{array[length - 1]}");
        PrintReversArray(array, length - 1);
    }
}

PrintArray(userArray);
Console.WriteLine();
PrintReversArray(userArray, userLength);

