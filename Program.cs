// Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементов массива.
// Семинар 3

using System.Buffers;

Console.WriteLine("Оригинальный массив: ");
double [] array = new double [5];
 double max = array[0];
  double min = array[0];
  double delta = array[0];

for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().NextDouble();
    Console.WriteLine(array[i]+ " ");
}

  for(int i = 0; i < array.Length; i++)
  {
    
       if (array[i] > max) 
       {
        max = array[i];
         Console.WriteLine($"Максимальное число {max} ");
       }
         
        if (array[i] < min)
        {
            min = array[i];
           Console.WriteLine($"Минимальное число {min} ");
        }
     
   
   delta = max - min; 

   Console.WriteLine($"разница между макс и мин элементом массива { delta }");
}


