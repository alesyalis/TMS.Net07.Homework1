using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.NET07.HOMEWORK1
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            { 
            Console.WriteLine("Insert the number");
            int number; //= int.Parse(Console.ReadLine());
            //Console.WriteLine(number);
            if (!int.TryParse(Console.ReadLine(), out number))  
            {
               Console.WriteLine("wrong input");
            }
            else
            {
              if(number != 0)
                {
                  Console.WriteLine(number);
                }
              else
                {
                  System.Environment.Exit(1);
                }
            }
            }
            while(true);
            

        }
    }
}
