// int i = 10, j = 20;
//
// if (i != j)
// {
//     if (i < j)
//     {
//         Console.WriteLine("i is less than j");
//     }
//     else if (i > j)
//     {
//        Console.WriteLine("i is greater than j");
//     }
// }
// else
//     Console.WriteLine("i is equal to j");
//







using System;
  class Triangle
{
    static void Main()
    {

      Console.WriteLine("To test triagles sides");
      string stringFirstNumber = Console.ReadLine();
        string stringSecondNumber = Console.ReadLine();
          string stringThirdNumber = Console.ReadLine();


      int firstNumber = int.Parse(stringFirstNumber);
      int secondNumber = int.Parse(stringSecondNumber);
        int thirdNumber = int.Parse(stringThirdNumber);

    {
        if (firstNumber == secondNumber && secondNumber == thirdNumber && thirdNumber == firstNumber )
        {
          Console.WriteLine("Equilateral");
        }
        else if (firstNumber == secondNumber || secondNumber == thirdNumber || thirdNumber == firstNumber)
        {
          Console.WriteLine("Isosceles");
        }
        else if (firstNumber + secondNumber <= thirdNumber || secondNumber + thirdNumber <= firstNumber || firstNumber + thirdNumber <= secondNumber)
        {
          Console.WriteLine("Cannot Form a Triangle");
        }

        else if (firstNumber != secondNumber && secondNumber != thirdNumber &&  thirdNumber != firstNumber)
        {
          Console.WriteLine("Scalene");
        }
        Main();
    }
  }
}
