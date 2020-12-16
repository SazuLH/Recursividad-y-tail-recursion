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
         int a, b;
         Console.WriteLine("Enter a first number: ");
         a = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Enter a second number: ");
         b = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("The mcd of the numbers is: " + mcd(a, b));
       }
       public static int mcd( int a, int b)
       {        
         
           if (a > b)
           {      
               b = mcd(a%b);	   
               return mcd(b,a);
           }
           else if(b == 0)
           {
               return a;
           }
           else
               return b;  
       }

    }
}
