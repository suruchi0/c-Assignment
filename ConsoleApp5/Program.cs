
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a C# Sharp program to print the output of multiplication of three numbers which will be entered by the user
using System;
public class multpli
{
    public static int multpliynumber(int num1, int num2, int num3)
    {
        int result = num1 * num2 * num3;
        return (result);
    }
    public static void Main()
    {
        int num1, num2, num3, result;

        Console.Write("Input the first number: ");
        num1 = int.Parse(Console.ReadLine());

        Console.Write("Input the second number: ");
        num2 = int.Parse(Console.ReadLine());

        Console.Write("Input the third number: ");
        num3 = int.Parse(Console.ReadLine());


    }
}
