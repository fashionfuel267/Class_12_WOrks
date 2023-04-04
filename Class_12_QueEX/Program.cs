using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_12_QueEX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue patientSl = new Queue();
            patientSl.Enqueue(1);
            patientSl.Enqueue(23);
            patientSl.Enqueue(2);
            patientSl.Enqueue(3);
            foreach(var item in patientSl)
            {
                Console.Write(item + "\t");
            }
            patientSl.Dequeue();
            Console.WriteLine("\nQueue after Deque");
            foreach (var item in patientSl)
            {
                Console.Write(item + "\t");
            }
            Console.ReadKey();
        }
    }
}
