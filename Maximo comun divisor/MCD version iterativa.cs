using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programs_VScode
{
    class Program
    {
      public static void Main(string[] args) 
      {
            Console.WriteLine("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            
            int a = Math.Max(num1, num2);
            int b = Math.Min(num1, num2);

            int res;
            
            do{
                res = b; 
                b = a%b; 
                a = res; 
            }  while(b!=0);
            
            Console.WriteLine("The mcd of the numbers is: " + res);
        }

    }
}
