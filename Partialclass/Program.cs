using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partialclass
{
    internal class Program
    {
        //Partial → incomplete class

// When we want to separate the task with multiple developers with diff files
//Diff files have same class name, but having diff methods implementation
//Complete the task of one class with help of multiple developers

        static void Main(string[] args)
        {
            calculator c1=new calculator();
            Console.WriteLine( c1.Add(55, 25));
            Console.WriteLine(c1.Sub(55, 25));
            Console.WriteLine(c1.Multiply(5, 5));
            c1.Invoke(25, 5);
            
        }
    }
}
