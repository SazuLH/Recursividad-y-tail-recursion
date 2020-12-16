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
         int f = 0;
         Console.WriteLine("Enter a number: ");
         f = Sum(int.Parse(Console.ReadLine()));
         Console.WriteLine("The sum is: ");
         Console.WriteLine(f);
       }
       public static int Sum(int n)
       {          
	       int r = 0;
           if(n > 1)
           {
            r = n + Sum(n - 1);
		   }
		   return r;
       }

    }
}
