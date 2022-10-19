using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
public class Calculator {
  public static void Main (string[] args) {

    Console.WriteLine("Calculator");
    Console.WriteLine("----------------------------");
    label:
    Console.WriteLine("1.Add");
    Console.WriteLine("2.Subtract");
    Console.WriteLine("3.Multiply");
    Console.WriteLine("4.Divide");
    Console.WriteLine("5.Modulo");
    Console.Write("Enter Choice(1-5):\t");

    int ch = Convert.ToInt32(Console.ReadLine());
    int a,b,c;
    
    switch (ch)
    {
      case 1:
        Console.Write("Enter A:\t");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter B:\t");
        b = Convert.ToInt32(Console.ReadLine());
        c = a+b;
        Console.WriteLine("Sum = {0}",c);
        break;
      case 2:
        Console.Write("Enter A:\t");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter B:\t");
        b = Convert.ToInt32(Console.ReadLine());
        c = a-b;
        Console.WriteLine("Difference = {0}",c);
        break;
      case 3:
        Console.Write("Enter A:\t");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter B:\t");
        b = Convert.ToInt32(Console.ReadLine());
        c = a*b;
        Console.WriteLine("Product = {0}",c);
        break;
      case 4:
        Console.Write("Enter A:\t");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter B:\t");
        b = Convert.ToInt32(Console.ReadLine());
        c = a/b;
        Console.WriteLine("Quotient = {0}",c);
        break;
      case 5:
        Console.Write("Enter A:\t");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter B:\t");
        b = Convert.ToInt32(Console.ReadLine());
        c = a%b;
        Console.WriteLine("Remainder = {0}",c);
        break;
      default:
        Console.WriteLine("Invalid Choice");
        break;
    }

    Console.Write("\n\nPress Y or y for continue. Press N or n for Exit (press Enter following the input):\t");
      char ans = Convert.ToChar(Console.ReadLine());
      if (ans == 'Y' || ans == 'y')
      {
        goto label; //goto label
      }
      else
      {
          Console.WriteLine("Press  Enter for Aborting...");
          Console.ReadLine();
          return;
      }
  }
}
}