using System;
using System.Collections;
using System.Globalization;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;
namespace WebApplication1;

public class Program
{
  public static void Main(){
    // System.Console.WriteLine("Enter a number:");
    // var a = Convert.ToInt16(Console.ReadLine());
    // System.Console.WriteLine("Enter another number:");
    // var b = Convert.ToInt16(Console.ReadLine());
    
        Console.Write("Input a number(integer): ");
        int number = Convert.ToInt32(Console.ReadLine());

        int sum = SumOfDigits(number);

        Console.WriteLine("Sum of the digits of the said integer: " + sum);
    }

    // Function to compute the sum of the digits of an integer
    public static int SumOfDigits(int num){
        int sum= 0;
        while(num!=0){
          sum+=num%10;
          num/=10;
          
        }return sum;
    }
}




