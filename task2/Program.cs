// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int Prompt(string message)
{
System.Console.Write(message);
  string readInput = System.Console.ReadLine();
  int result = int.Parse(readInput);
  return result;
}

int SumAllDigit(int number)
{
  int result = 0;
  while (number > 0)
  {
    result += number % 10;
    number = number / 10;
  }
  return result;
}

int number = Prompt("Введите чило: ");
System.Console.WriteLine($"Сумма всех чисел в цифре {number} = {SumAllDigit(number)}");



// int numberA = ReadInt("Число A: ");
// int numberB = ReadInt("Число B: ");
// ToDegree(numberA, numberB);

// void ToDegree(int a, int b)
// {
//   int result = 1;
//   for (int i = 1; i <= b; i++)
//   {
//     result = result * a;
//   }
//   Console.WriteLine(result);
// }

// int ReadInt(string message)
// {
//   Console.WriteLine(message);
//   return Convert.ToInt32(Console.ReadLine());
// }