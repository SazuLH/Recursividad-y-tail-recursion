using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programs_VScode
{
    class Program
    {
       static void Main (string[] args)
       {
         int num;
           Console.WriteLine("Enter a number: ");
           num = int.Parse(Console.ReadLine());
           Console.WriteLine("Numbers: ");
           int count = 1;
           int fac = 1;
           while(count <= num)
           {
               fac = fac * count;
               Console.WriteLine(count);
               count++;
           }

           Console.WriteLine("Factorial: ");
           Console.WriteLine(fac);
       }
       

    }
}
