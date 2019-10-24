using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX062
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack S = new Stack(5);
            S.Push(1);	//Stack contains 1
            S.Push(2);	//Stack contains 1 2
            S.Push(3);	//Stack contains 1 2 3
            Console.WriteLine(S.Pop()); //Prints 3, stack contains 1 2
            Console.WriteLine(S.Pop()); //Prints 2, stack contains 1
            Console.WriteLine(S.Count());

        }
    }
}
