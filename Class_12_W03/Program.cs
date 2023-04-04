using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_12_W03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("Jamal");
            list.Add("Gopal");
            list.Add("Doyel");
            list.Add("Doyal");
            foreach(var item in list)
            {
                Console.Write(item+"\t");
            }
            list.Add("Popi");
            foreach (var item in list)
            {
                Console.Write("\n"+item + "\t");
            }
            list.AddRange(new List<string>
            {
                "koli","payel","Hasi"
            });
            Console.WriteLine("\nAfter addRange");
            foreach (var item in list)
            {
                Console.Write( item + "\t");
            }
            Console.WriteLine();
            Console.WriteLine("\nAfter Insert");
            list.Insert(3, "3item");

            foreach (var item in list)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine();
            Console.WriteLine( list.Contains("Payel"));
            Console.ReadKey();
        }
    }
}
