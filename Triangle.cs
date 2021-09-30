using System;

namespace Triangle
{
    class Program
    {
    static void Main(string[] args)
    {

      Console.WriteLine("Ping Pong");
      Console.WriteLine("Please Enter A Number");
      string userNumber = Console.ReadLine();
      int number = int.Parse(userNumber);
      for (int i = 1; i <= number; i++)
      {
        if (i % 3 == 0 && i % 5 == 0)
        {
          Console.WriteLine("Ping Pong");
        }
        else if (i % 3 == 0)
        {
          Console.WriteLine("Ping");
        }
        else if (i % 5 == 0)
        {
          Console.WriteLine("Pong");
        }
        else
        {
          Console.WriteLine(i);
        }
      }
