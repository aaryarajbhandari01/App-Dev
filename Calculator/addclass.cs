using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1.Calculator
{
     class Add
    {
        public static void Addition()
        {
            Console.WriteLine("enter a number");
            var v1 = Console.ReadLine();
            Console.WriteLine("enter a another number");
            var v2 = Console.ReadLine();

            var sum = Convert.ToInt32(v1) + Convert.ToInt32(v2);
            Console.WriteLine($"Sum of inputs: {sum}");



        }


    }
}
