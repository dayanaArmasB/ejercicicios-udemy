using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ejercicios_udemy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables necesarias
            int opcion;
            string nombre;
            long numero;

            Dictionary<string, long> contactos = new Dictionary<string, long>();

            do
            {
                Console.Clear();

                Console.WriteLine("1. Agregar contacto");
                Console.WriteLine("2. Buscar contacto");
                Console.WriteLine("3. Eliminar contacto");
                Console.WriteLine("4. Mostrar contacto");
                Console.WriteLine("5. Actualizar contacto");

                Console.Write("\nEscoge una opion: ");
                opcion = int.Parse(Console.ReadLine());

                Console.Clear();

                switch(opcion)
                {
                    case 1:
                        Console.WriteLine("nombre: ");
                        nombre = Console.ReadLine();

                        Console.WriteLine("numero: ");
                        numero = int.Parse(Console.ReadLine());

                        contactos.Add(nombre, numero);

                        Console.WriteLine("\n ({0}) se ha agregado con exito", nombre);
                        Console.WriteLine("\n presiona cualquier tecla para regresar al menu...");

                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Write("Buscar contacto por nombre: ");
                        nombre = Console.ReadLine();
                        if((contactos.ContainsKey(nombre)))
                        {
                           Console.WriteLine("\n j Contacto encontrado ! ");
                           Console.WriteLine(" (0) : (1)", nombre, contactos[nombre]);
                           Console.WriteLine("\nPresiona cualquier tecla para regresar al menú... ");
                           Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("\n¡E1 contacto no existe!");
                            Console.WriteLine("\n presiona cualquier tecla para regresar al mепú...");
                            Console.ReadKey();
                        }
                        break;
                    case 3:
                        Console.Write("Contacto a eliminar: ");
                        nombre = Console.ReadLine();
                        if ((contactos.ContainsKey(nombre)))
                        {
                            contactos.Remove(nombre);

                            Console.WriteLine("\n({9}) ha sido eliminado con exito", nombre);


                            Console.WriteLine("\nPresiona cualquier tecla para regresar al menú... ");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("\n¡E1 contacto no existe!");
                            Console.WriteLine("\n presiona cualquier tecla para regresar al mепú...");
                            Console.ReadKey();
                        }
                        break;
                    case 4:
                        Console.WriteLine("Contactos en tu agenda: \n");

                        foreach (KeyValuePair<string, long> elemento in contactos)
                        {
                            Console.WriteLine("{0}: {1}", elemento.Key , elemento.Value);
                            Console.WriteLine("\n presiona cualquier tecla para regresar al mепú...");
                            Console.ReadKey();
                        }
                        break;
                    case 5:
                        Console.Write("Actualizar contacto (ingrese el nombre): ");
                        nombre = Console.ReadLine();
                        if ((contactos.ContainsKey(nombre)))
                        {
                            Console.WriteLine("\nIngrese el nuevo numero ");
                            numero = int.Parse(Console.ReadLine());
                            contactos[nombre] = numero;
                            Console.WriteLine("\nInformacion actualizada");
                            Console.WriteLine("\nPresiona cualquier tecla para regresar al menú... ");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("\n¡E1 contacto no existe!");
                            Console.WriteLine("{0}: {1}", nombre, contactos[nombre]);
                            Console.WriteLine("\n presiona cualquier tecla para regresar al mепú...");
                            Console.ReadKey();
                        }
                        break;

                }

            } while (opcion >= 1 && opcion <= 5);
        }
    }
}
