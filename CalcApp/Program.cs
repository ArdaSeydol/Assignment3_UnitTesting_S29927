using System;
using Assignment3_S29927;

class Program
{
    static void Main()
    {
        var calc = new Calculator();
        Console.WriteLine(calc.Add(10, 2));       // 12
        Console.WriteLine(calc.Subtract(10, 2));  // 8
        Console.WriteLine(calc.Multiply(3, 4));   // 12
        Console.WriteLine(calc.Divide(20, 5));    // 4
    }
}
