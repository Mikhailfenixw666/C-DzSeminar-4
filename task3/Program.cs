// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int Prompt(string message)
{
  System.Console.Write(message);
  string readInput = System.Console.ReadLine();
  int result = int.Parse(readInput);
  return result;
}

int[] GenerateArray(int Length, int minValue, int maxValue)
{
  int[] array = new int[Length];
  Random random = new Random();
  for (int i = 0; i <Length; i++)
  {
    array[i] = random.Next(minValue, maxValue + 1);
  }
  return array;
}

void PrintArray(int[] array)
{
  System.Console.Write("[");
  for (int i = 0; i < array.Length - 1; i++)
  {
  System.Console.Write($"{array[i]}, ");
  }
  System.Console.Write($"{array[array.Length - 1]}, ");
  System.Console.Write("]");
}

int length = Prompt("Длина массива: ");
int min = Prompt("Начальное значение, для диапазона случаного числа: ");
int max = Prompt("Конечное значение, для диапазона случайного числа: ");
int[] array = GenerateArray(length, min, max);
PrintArray(array);





// int[] GenerateArray(int size)
// {

// int[] array = new int[size];

// Random rand = new Random();

// for(int i = 0; i < size; i++)
// {
// array[i] = rand.Next(1, 34);
// }
// return array;
// }

// var myArray = GenerateArray(8);

// System.Console.WriteLine("[" + string.Join(", ", myArray) + "]");