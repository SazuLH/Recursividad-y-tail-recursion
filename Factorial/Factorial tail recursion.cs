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
         int f = 1;
         Console.WriteLine("Enter a number: ");
         f = fac(int.Parse(Console.ReadLine()));
         Console.WriteLine("The factor is: ");
         Console.WriteLine(f);
       }
       public static int fac(int n,  int r = 1)
       {
          
           if(n < 1)
           
           return r;
           
           return fac(n - 1, n * r);
       }

    }
}
