
using System;
using HelloworldMsg;
using Week1.Calculator;

namespace Helloworld
{
    class Program
    { 
        static void Main(string[] args)
         {
            Hello msgObj = new Hello();
            Console.WriteLine(msgObj.msg);

            Add addObj = new Add();
            Add.Addition();
        }
    }
}