using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_proyecto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista milista = new Lista(); // Creamos una nueva lista vacía.
            int opcion = 0;

            // Este ciclo se repite hasta que el usuario elija salir (opción 8).
            do
            {
                Console.Clear();
                Console.WriteLine("MENU LISTAS");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("1.- Insertar Nodo");
                Console.WriteLine("2.- Imprimir Tamaño");
                Console.WriteLine("3.- Buscar Nodo por Posición");
                Console.WriteLine("4.- Borrar Nodo");
                Console.WriteLine("5.- Modificar Nodo");
                Console.WriteLine("6.- Buscar Nodo por Valor");
                Console.WriteLine("7.- Imprimir Lista");
                Console.WriteLine("8.- Salir");
                Console.Write("Seleccionar Opción => ");
                opcion = int.Parse(Console.ReadLine()); // Leemos la opción del usuario.

                switch (opcion)
                {
                    case 1:
                        // Opción para insertar un nodo.
                        Console.Write("Teclear valor del nodo a insertar: ");
                        int valorInsertar = int.Parse(Console.ReadLine());
                        milista.Add(valorInsertar); // Agregamos el nuevo valor a la lista.
                        Console.WriteLine("Nodo insertado correctamente.");
                        break;

                    case 2:
                        // Opción para imprimir el tamaño de la lista.
                        int tamano = milista.Count();
                        Console.WriteLine($"La lista tiene {tamano} nodos.");
                        break;

                    case 3:
                        // Opción para buscar un nodo por su posición.
                        Console.Write("Dame la posición del nodo a buscar: ");
                        int posBuscar = int.Parse(Console.ReadLine());
                        int valorNodo = milista.Find(posBuscar);
                        if (valorNodo != -1)
                            Console.WriteLine($"El valor en la posición {posBuscar} es: {valorNodo}");
                        else
                            Console.WriteLine("Posición no válida.");
                        break;

                    case 4:
                        // Opción para borrar un nodo por su posición.
                        Console.Write("Dame la posición del nodo a borrar: ");
                        int posBorrar = int.Parse(Console.ReadLine());
                        if (milista.Delete(posBorrar))
                            Console.WriteLine("Nodo borrado correctamente.");
                        else
                            Console.WriteLine("Posición no válida o lista vacía.");
                        break;

                    case 5:
                        // Opción para modificar el valor de un nodo.
                        Console.Write("Dame la posición del nodo a modificar: ");
                        int posModificar = int.Parse(Console.ReadLine());
                        Console.Write("Dame el nuevo valor: ");
                        int nuevoValor = int.Parse(Console.ReadLine());
                        if (milista.Change(posModificar, nuevoValor))
                            Console.WriteLine("Nodo modificado correctamente.");
                        else
                            Console.WriteLine("No se pudo modificar el nodo.");
                        break;

                    case 6:
                        // Opción para buscar un nodo por su valor.
                        Console.Write("Dame el valor a buscar: ");
                        int valorBuscar = int.Parse(Console.ReadLine());
                        int posicion = milista.FindValue(valorBuscar);
                        if (posicion != -1)
                            Console.WriteLine($"El valor {valorBuscar} está en la posición {posicion}.");
                        else
                            Console.WriteLine("Valor no encontrado.");
                        break;

                    case 7:
                        // Opción para imprimir todos los nodos de la lista.
                        Console.Write("Contenido de la lista: \n");
                        milista.print();
                        break;

                    case 8:
                        // Opción para salir del programa.
                        Console.WriteLine("Saliendo...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

                Console.WriteLine("\nPresiona Enter para continuar...");
                Console.ReadLine(); // Pausa para que el usuario pueda leer el mensaje antes de continuar.

            } while (opcion != 8); // El ciclo se repite mientras la opción no sea 8 (salir).
        }
    }
}