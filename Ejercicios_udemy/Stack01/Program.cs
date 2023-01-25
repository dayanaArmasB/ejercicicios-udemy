using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //esto es temporal
            Console.WriteLine("esto lo tienes que mover luiego");
            int i = 0;
            int j = 0;
            //implementación de la Clase Queue
            Queue q = new Queue();
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            Console.WriteLine("Los Elementos de la Lista son:");
            while (q.Count > 0)
            {
                Console.WriteLine(q.Dequeue());
                i++;
            }
            Console.WriteLine("Ahora el contenido de nuestra Cola son:" + q.Count);
            Console.WriteLine("la cantidad de numeros en la cola son:" + i++);
            //Console.ReadKey();

            //implementación de la Clase Stack
            Stack s = new Stack();
            s.Push(1);
            s.Push(2);
            s.Push(3);
            Console.WriteLine("Los Elementos que tenemos en la Pila son:");
            while (s.Count > 0)
            {
                Console.WriteLine(s.Pop());
                j++;
            }

            Console.WriteLine("Ahora el contenido de nuestra Cola son:" + s.Count);
            Console.WriteLine("la cantidad de numeros en la cola son:" + j++);
            Console.ReadKey();
        }
    }
}
