using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            char operacion;
            char Opcion;

            Console.WriteLine("Programa para realizar operaciones de dos números");
            do
            {
                Console.WriteLine("Desea continuar..(s/n)");
                Opcion = char.Parse(Console.ReadLine());
                if (Opcion == 'n')
                {
                    break;
                }
                Console.WriteLine("Digite la opcion que desea realizar: ");
                Console.WriteLine("1- Sumar");
                Console.WriteLine("2- Restar");
                Console.WriteLine("3- Dividir");
                Console.WriteLine("4- Multiplicar");
                Console.WriteLine("5- Salir");
                operacion = char.Parse(Console.ReadLine());


                if (Opcion == 's'&& operacion!='5')
                {
                    Console.WriteLine("Escriba el primer numero: ");
                    num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Escriba el segundo numero: ");
                    num2 = int.Parse(Console.ReadLine());
                }
                else break;

                switch (operacion)
                {
                    case '1':
                    Console.WriteLine("La suma de los numeros es: " + (num1 + num2));
                    break;
                    case '2':
                    Console.WriteLine("La resta de los numeros es: " + (num1 - num2));
                    break;
                    case '3':
                    Console.WriteLine("La división de los numeros es: " + (num1 / num2));
                    break;
                    case '4':
                    Console.WriteLine("La multiplicación de los numeros es: " + (num1 * num2));
                    break;
                    case '5':
                        break;
                    

                }

            } while (!Opcion.Equals('n'));
            
            Console.ReadLine();
        }
    }
}
