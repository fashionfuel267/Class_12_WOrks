using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_12_W02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(11);
            stack.Push(21);
            stack.Push(13);
            stack.Push(14);
            foreach(var item in stack)
            {
                Console.Write(item+"\t");
            }
            Console.WriteLine("\nPop");
            stack.Pop();
            foreach (var item in stack)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine($"\nPeek the top item: {stack.Peek()}");
            Console.ReadKey();
        }
    }
}
