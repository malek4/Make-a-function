using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
          /* int  c = a + b;
           int d = a - b;
           int e = a * b;
           int f = a / b;*/
           /* Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);*/
            string op =Console.ReadLine();

            switch (op)
            {
                case "+":
                    Console.WriteLine(a + b);  
                    break;
                case "-":
                    Console.WriteLine(a - b);
                    break;
                case "*":
                    Console.WriteLine(a * b);
                    break;
                case "/":
                    Console.WriteLine(a / b);
                    break;
            }
            Console.ReadKey();








                    
           
            
            























        }
    }
}
