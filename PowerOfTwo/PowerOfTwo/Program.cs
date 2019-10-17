using System;

namespace PowerOfTwo
{
  class Program
  {
    static void Main(string[] args)
    {
      if (args.Length > 0)
      {
        var result = Power(args[0]);
        Console.WriteLine($" Power of 2 for {args[0]} is {result:N2}");
      }
      else
      {
        Console.WriteLine("Missing arguments");
      }

      double Power(int powerRaised)
      {

        if (powerRaised != 0)
        {
          return (2 * Power(powerRaised - 1));
        }
        else
        {
          return 1;
        }
      }

    }

  }
}
