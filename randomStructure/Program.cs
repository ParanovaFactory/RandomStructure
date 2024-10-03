using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace randomStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int num = random.Next();
            int num1 = random.Next(0,11); 
            int num2 = random.Next(99); 
            double num3 = random.NextDouble();
            Console.WriteLine(num + " |-| " + num1 + " |-| " + num2 + " |-| " + num3);
            Console.ReadLine();
        }
    }
}
