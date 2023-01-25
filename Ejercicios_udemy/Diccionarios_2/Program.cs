using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diccionarios_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            float gasto;

            Stack<float> gastos = new Stack<float>();

            do
            {
                Console.Clear();
                Console.WriteLine("1 agregar gastos");
                Console.WriteLine("2 mostrar gastos del mes");
                Console.WriteLine("1 pago para no generar intereses");

                Console.WriteLine("escoge una opcion");
                opcion = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("monto: $");
                        gasto = float.Parse(Console.ReadLine());
                   
                            gastos.Push(gasto);
                        break;
                    case 2:
                        Console.WriteLine("gastos del mes: \n");
                        foreach (float elemento in gastos)
                        {
                            Console.WriteLine("{0}", elemento);
                        }
                        Console.WriteLine("\n presiona cualquier tecla para regresar continuar...");

                        Console.ReadKey();
                        break;
                    case 3:

                        float total = 0;

                        foreach (float elemento in gastos)
                        { 
                        total = total + elemento;
                        }

                        Console.WriteLine("pago para no generar intereses: $ {0} ", total);
                      
                        Console.WriteLine("\n presiona cualquier tecla para regresar continuar...");

                        Console.ReadKey();
                        break;
                }

              

            } while (opcion >= 1 && opcion <= 3);



            int k = 0;
            Dictionary<int, string> diccionario = new Dictionary<int, string>()
            {
                { 1, "Uno" },
                { 2, "Dos" },
                { 3, "Tres" },
                { 3, "tres" }
            };
            foreach (KeyValuePair<int, string> elemento in diccionario)
            {
                Console.WriteLine("Clave: {0}, Valor: {1}", elemento.Key, elemento.Value);
            }
            for (int i = 0; i < diccionario.Count; i++)
            {
                k++;
            }

            Console.WriteLine("HAY " + k + " ELEMENTOS");

            Console.ReadKey();

        }
    }
}
